using Abot2.Poco;
using AbotX2.Parallel;
using AbotX2.Poco;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using XLeech.Core.Extensions;
using XLeech.Core.Service;
using XLeech.Data.Entity;
using XLeech.Data.EntityFramework;
using XLeech.Data.Repository;

namespace XLeech
{
    public partial class Dashboard : UserControl
    {
        private readonly AppDbContext _dbContext;
        private readonly Repository<SiteConfig> _siteConfigRepository;
        private readonly Repository<CategoryConfig> _categoryConfigRepository;
        private readonly Repository<PostConfig> _postConfigRepository;
        private readonly ICrawlerService _crawlerService;
        private ParallelCrawlerEngine _parallelCrawlerEngine;
        private int categoryCrawled = 0;
        private int postSuccess = 0;
        private int postFailed = 0;

        public Dashboard()
        {
            InitializeComponent();

            if (Main.AppWindow.AppDbContext != null)
            {
                _dbContext = Main.AppWindow.AppDbContext;
            }

            if (Main.AppWindow.SiteConfigRepository != null)
            {
                _siteConfigRepository = Main.AppWindow.SiteConfigRepository;
            }

            if (Main.AppWindow.CrawlerService != null)
            {
                _crawlerService = Main.AppWindow.CrawlerService;
            }

            if (Main.AppWindow.ParallelCrawlerEngine != null)
            {
                _parallelCrawlerEngine = Main.AppWindow.ParallelCrawlerEngine;

                categoryCrawled = _parallelCrawlerEngine.Impls.ImplementationBag.CategoryCrawled;
                LogLabel(this.CategoryCrawledLb, categoryCrawled.ToString());

                postSuccess = _parallelCrawlerEngine.Impls.ImplementationBag.PostSuccess;
                LogLabel(this.PostSuccessLb, postSuccess.ToString());

                postFailed = _parallelCrawlerEngine.Impls.ImplementationBag.PostFailed;
                LogLabel(this.PostFailedLb, postFailed.ToString());

                _parallelCrawlerEngine.CrawlerInstanceCreated += (sender, eventArgs) =>
                {
                    eventArgs.Crawler.CrawlBag.SiteConfig = eventArgs.SiteToCrawl.SiteBag.SiteConfig;
                    eventArgs.Crawler.PageCrawlCompleted += async (abotSender, abotEventArgs) =>
                    {
                        var siteConfig = abotEventArgs.CrawlContext.CrawlBag.SiteConfig as SiteConfig;

                        try
                        {
                            if (string.IsNullOrEmpty(abotEventArgs.CrawledPage.Content.Text) || siteConfig == null) throw new Exception("Content empty");

                            var crawlerResult = await _crawlerService.PageCrawlCompleted(abotSender, abotEventArgs, siteConfig);

                            Interlocked.Increment(ref postSuccess);
                            _parallelCrawlerEngine.Impls.ImplementationBag.PostSuccess = postSuccess;

                            LogLabel(this.PostSuccessLb, postSuccess.ToString());
                            LogPost(string.Format("{0} Completed, {1}", abotEventArgs.CrawledPage.Uri, crawlerResult.IsSavePost ? "Save" : "Skiped"));
                        }
                        catch (Exception ex)
                        {
                            Interlocked.Increment(ref postFailed);
                            _parallelCrawlerEngine.Impls.ImplementationBag.PostFailed = postFailed;

                            LogLabel(this.PostFailedLb, postFailed.ToString());
                            LogPost(string.Format("{0} Exception {1}", siteConfig?.Url, ex.Message));
                        }
                    };

                    var postUrls = eventArgs.SiteToCrawl.SiteBag.PostUrls as List<string>;
                    eventArgs.Crawler.CrawlContext.CrawlConfiguration.MinCrawlDelayPerDomainMilliSeconds = 3000;
                    eventArgs.Crawler.CrawlContext.CrawlConfiguration.MaxLinksPerPage = 1;
                    eventArgs.Crawler.CrawlContext.CrawlConfiguration.MaxPagesToCrawl = 1;
                    eventArgs.Crawler.CrawlContext.Scheduler.Add(postUrls.Select(u => new PageToCrawl(new Uri(u))));
                };

                _parallelCrawlerEngine.SiteCrawlStarting += (sender, args) =>
                {
                };

                _parallelCrawlerEngine.SiteCrawlCompleted += async (sender, siteCrawleArgs) =>
                {
                    Interlocked.Increment(ref categoryCrawled);
                    LogLabel(this.CategoryCrawledLb, categoryCrawled.ToString());
                    _parallelCrawlerEngine.Impls.ImplementationBag.CategoryCrawled = categoryCrawled;

                    var siteConfig = siteCrawleArgs.CrawledSite.SiteToCrawl.SiteBag.SiteConfig as SiteConfig;

                    var urlCategoryNextPage = siteCrawleArgs.CrawledSite.SiteToCrawl.SiteBag.CategoryNextPageURL as string;
                    var site = await _siteConfigRepository.GetByIdAsync(siteConfig.Id);
                    site.CategoryNextPageURL = urlCategoryNextPage;
                    site.IsDone = string.IsNullOrEmpty(urlCategoryNextPage);
                    await _siteConfigRepository.UpdateAsync(siteConfig);
                    if (!site.IsDone)
                    {
                        var category = _dbContext.Categories.Where(x => x.SiteID == site.Id).FirstOrDefault();
                        site.Category = category;
                        var post = _dbContext.Posts.Where(x => x.SiteID == site.Id).FirstOrDefault();
                        site.Post = post;
                        CrawleSite(site);
                    }
                };

                _parallelCrawlerEngine.AllCrawlsCompleted += async (sender, eventArgs) =>
                {
                    Interlocked.Increment(ref categoryCrawled);
                    LogLabel(this.CategoryCrawledLb, categoryCrawled.ToString());
                };
            }
        }

        private static CrawlConfigurationX GetSafeConfig()
        {
            return new CrawlConfigurationX
            {
                MaxPagesToCrawl = 1,
                MinCrawlDelayPerDomainMilliSeconds = 3000,
                MinSiteToCrawlRequestDelayInSecs = 3000,
                MaxConcurrentSiteCrawls = 3,
                IsSendingCookiesEnabled = true,
                CrawlTimeoutSeconds = 100,
                MaxRetryCount = 2,
                MinRetryDelayInMilliseconds = 100,
                //HttpRequestTimeoutInSeconds= 60,
                //MaxConcurrentThreads = 5,
            };
        }

        private async Task CrawleEngineAsync()
        {
            var sites = await _siteConfigRepository
                       .Where(x => x.ActiveForScheduling && !x.IsDone)
                       .Include(x => x.Category)
                       .Include(y => y.Post)
                       .AsNoTracking()
                       .ToListAsync();
            this.AllSiteLb.Text = sites?.Count.ToString();
            if (sites != null && sites.Any())
            {
                foreach (var site in sites)
                {
                    var category = _dbContext.Categories.Where(x => x.SiteID == site.Id).AsNoTracking().FirstOrDefault();
                    site.Category = category;
                    var post = _dbContext.Posts.Where(x => x.SiteID == site.Id).AsNoTracking().FirstOrDefault();
                    site.Post = post;
                    CrawleSite(site);
                }
            }
            else
            {
                MessageBox.Show("No sites to crawle");
            }
        }

        private async Task<ParallelCrawlerEngine> CrawleSite(SiteConfig siteConfig)
        {
            var siteToCrawls = new List<SiteToCrawl>();
            var config = GetSafeConfig();

            try
            {
                // get urls from post list
                if (siteConfig.IsPageUrl == true)
                {
                    string[] postUrls = siteConfig.Category.Urls?.ToListString();
                    if (postUrls != null && postUrls.Any())
                    {
                        siteToCrawls.AddRange(
                            postUrls.Select(x => new SiteToCrawl
                            {
                                Uri = new Uri(x),
                                SiteBag = siteConfig
                            }).ToList()
                        );
                    }
                }

                // get urls from url category page
                if (siteConfig.IsPageUrl == false)
                {
                    var urlCategoryPageCrawle = _crawlerService.GetURLCategoryPageCrawle(siteConfig);
                    var categoryPageInfo = await _crawlerService.GetInfoCategoryPage(siteConfig, config);
                    LogSite(string.Format("{0}, post count: {1}", urlCategoryPageCrawle, categoryPageInfo.PostUrls.Count()));
                    if (categoryPageInfo != null && categoryPageInfo.PostUrls.Any())
                    {
                        var siteToCrawle = new SiteToCrawl
                        {
                            Uri = new Uri(urlCategoryPageCrawle)
                        };
                        siteToCrawle.SiteBag.SiteConfig = siteConfig;
                        siteToCrawle.SiteBag.PostUrls = categoryPageInfo.PostUrls;
                        siteToCrawle.SiteBag.CategoryNextPageURL = categoryPageInfo.CategoryNextPageURL;
                        siteToCrawls.Add(siteToCrawle);
                    }
                }

                _parallelCrawlerEngine.Impls.SiteToCrawlProvider.AddSitesToCrawl(siteToCrawls);
            }
            catch (Exception ex)
            {
                LogSite(string.Format("{0} Exception {1}", siteConfig.Url, ex.Message));
            }

            return new ParallelCrawlerEngine(config);
        }

        private async void StartBtn_Click(object sender, EventArgs e)
        {
            CrawleEngineAsync();
        }

        private async void ReCrawleBtn_Click(object sender, EventArgs e)
        {
            var sites = _siteConfigRepository.Where(x => true)
                       .Include(x => x.Category)
                       .Include(y => y.Post)
                       .ToList();
            if (sites.Any())
            {
                foreach (var site in sites)
                {
                    site.IsDone = false;
                    site.CategoryNextPageURL = null;
                    await _siteConfigRepository.UpdateAsync(site);
                }
            }

            CrawleEngineAsync();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            _parallelCrawlerEngine.Stop();
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            _parallelCrawlerEngine.Pause();
        }

        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            _parallelCrawlerEngine.Resume();
        }

        #region Log

        private void LogLabel(Label label, string log)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(() =>
                {
                    label.Text = log;
                });
            }
            else
            {
                label.Text = log;
            }
        }

        private void LogSite(string log)
        {
            ShowLog(this.LogSiteTb, log);
        }

        private void LogPost(string log)
        {
            ShowLog(this.LogPostTb, log);
        }

        private void ShowLog(RichTextBox richTextBox, string log)
        {
            if (richTextBox.InvokeRequired)
            {
                richTextBox.Invoke(() =>
                {
                    richTextBox.Text += string.Format("{0} {1}\n", DateTime.Now.ToString(Constants.FormatDateShowLog), log);
                    richTextBox.SelectionStart = richTextBox.Text.Length;
                    richTextBox.ScrollToCaret();
                });
            }
            else
            {
                richTextBox.Text += string.Format("{0} {1}\n", DateTime.Now.ToString(Constants.FormatDateShowLog), log);
                richTextBox.SelectionStart = richTextBox.Text.Length;
                richTextBox.ScrollToCaret();
            }
        }

        #endregion Log
    }
}