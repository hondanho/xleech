using Microsoft.EntityFrameworkCore;
using System.Security.Policy;
using XLeech.Core.Extensions;
using XLeech.Data.Entity;
using XLeech.Data.EntityFramework;
using XLeech.Data.Repository;
using XLeech.Model;

namespace XLeech
{
    public partial class SiteDetail : UserControl
    {
        private readonly AppDbContext _dbContext;
        private readonly Repository<SiteConfig> _siteRepository;
        private readonly Repository<CategoryConfig> _categoryRepository;
        private readonly Repository<PostConfig> _postRepository;

        private SiteConfig _siteConfig;
        public Action _backToListSite;

        public SiteDetail()
        {
            InitializeComponent();
            if (Main.AppWindow?.AppDbContext != null)
            {
                _dbContext = Main.AppWindow?.AppDbContext;
            }
            if (Main.AppWindow?.CategoryRepository != null)
            {
                _siteRepository = Main.AppWindow?.SiteConfigRepository;
            }
            if (Main.AppWindow?.CategoryRepository != null)
            {
                _categoryRepository = Main.AppWindow?.CategoryRepository;
            }
            if (Main.AppWindow?.PostRepository != null)
            {
                _postRepository = Main.AppWindow?.PostRepository;
            }
        }

        public void SetCallback(Action backToListSite)
        {
            _backToListSite = backToListSite;
        }

        public void SetViewCreateSite()
        {
            this.saveBtn.Text = ButtonNameConsts.Create;
            this.saveBtn.Click += CreateBtn_Click;
            _siteConfig = new SiteConfig();
            SetShowTypeCrawler();
        }

        public void SetViewEditSite(int siteId)
        {
            this.saveBtn.Text = ButtonNameConsts.Edit;
            this.saveBtn.Click += EditBtn_Click;

            var siteConfig = _dbContext.Sites
                        .Where(x => x.Id == siteId)
                        .Include(x => x.Category)
                        .Include(x => x.Post)
                        .FirstOrDefault();
            _siteConfig = siteConfig;
            if (siteConfig != null)
            {
                // site
                this.NameTb.Text = siteConfig.Name;
                this.UrlTxt.Text = siteConfig.Url;
                this.ActiveForSchedulingCb.Checked = siteConfig.ActiveForScheduling;
                this.IsTryTestCb.Checked = siteConfig.IsTryTest;
                this.CategoryPageRb.Checked = !siteConfig.IsPageUrl;
                this.ListUrlRb.Checked = siteConfig.IsPageUrl;
                this.CheckDuplicatePostViaContentCb.Checked = siteConfig.CheckDuplicatePostViaContent;
                this.CheckDuplicatePostViaTitleCb.Checked = siteConfig.CheckDuplicatePostViaTitle;
                this.CheckDuplicatePostViaUrlCb.Checked = siteConfig.CheckDuplicatePostViaUrl;
                this.MaximumPagesCrawlPerCategoryNumeric.Value = (decimal)siteConfig.MaximumPagesCrawlPerCategory;
                this.MaximumPagesCrawlPerPostNumeric.Value = (decimal)siteConfig.MaximumPagesCrawlPerPost;
                this.HTTPUserAgentTb.Text = siteConfig.HTTPUserAgent;
                this.connectionTimeoutNumeric.Value = (decimal)siteConfig.ConnectionTimeout;
                this.UseProxyCb.Checked = siteConfig.UseProxy;
                this.ProxiesTb.Text = siteConfig.Proxies;
                this.ActiveForPostSpinningCb.Checked = siteConfig.ActiveForPostSpinning;
                this.ActiveForPostTranslationCb.Checked = siteConfig.ActiveForPostTranslation;
                this.RandomizeProxiesCb.Checked = siteConfig.RandomizeProxies;
                this.TimeIntervalNumeric.Value = (decimal)siteConfig.TimeInterval;
                this.NoteTb.Text = siteConfig.Notes;
                this.CookieCb.Text = siteConfig.Cookie;
                this.ProxyRetryLimitNumeric.Value = siteConfig.ProxyRetryLimit;
                this.WordpressApiUrlTb.Text = siteConfig.WordpressApiUrl;
                this.WordpressUserNameTb.Text = siteConfig.WordpressUserName;
                this.WordpressApplicationPWTb.Text = siteConfig.WordpressApplicationPW;

                // category
                this.CategoryMapTb.Text = siteConfig.Category.CategoryMap;
                this.SaveFeaturedImagesCb.Checked = siteConfig.Category.SaveFeaturedImages;
                this.FeaturedImageSelectorTb.Text = siteConfig.Category.FeaturedImageSelector;
                this.FindAndReplaceRawHTMLTb.Text = siteConfig.Category.FindAndReplaceRawHTML;
                this.RemoveElementAttributesTb.Text = siteConfig.Category.RemoveElementAttributes;
                this.UnnecessaryElementsTb.Text = siteConfig.Category.UnnecessaryElements;
                this.CrawlerUrlsTb.Text = siteConfig.Category.Urls;
                this.CategoryListPageURLTb.Text = siteConfig.Category.CategoryListPageURL;
                this.CategoryListURLSelectorTb.Text = siteConfig.Category.CategoryListURLSelector;
                this.CategoryPostUrlTb.Text = siteConfig.Category.CategoryPostURL;
                this.CategoryPostURLSelectorTb.Text = siteConfig.Category.CategoryPostURLSelector;
                this.CategoryNextPageURLSelectorTb.Text = siteConfig.Category.CategoryNextPageURLSelector;
                this.CategoryDescriptionTb.Text = siteConfig.Category.Description;

                //post
                this.PostFormatCb.Text = siteConfig.Post.PostFormat;
                this.PostTypeCb.Text = siteConfig.Post.PostType;
                this.PostAuthorTb.Text = siteConfig.Post.PostAuthor;
                this.PostStatusCb.Text = siteConfig.Post.PostStatus;
                this.PostTitleSelectorTb.Text = siteConfig.Post.PostTitleSelector;
                this.PostExcerptSelectorTb.Text = siteConfig.Post.PostExcerptSelector;
                this.PostContentSelectorTb.Text = siteConfig.Post.PostContentSelector;
                this.PostTagSelectorTb.Text = siteConfig.Post.PostTagSelector;
                this.PostSlugSelectorTb.Text = siteConfig.Post.PostSlugSelector;
                this.CategoryNameSelectorTb.Text = siteConfig.Post.CategoryNameSelector;
                this.CategoryNameSeparatorSelectorTb.Text = siteConfig.Post.CategoryNameSeparatorSelector;
                this.PostDateSelectorTb.Text = siteConfig.Post.PostDateSelector;
                this.SaveMetaKeywordsCb.Checked = siteConfig.Post.SaveMetaKeywords;
                this.AddMetaKeywordsAsTagCb.Checked = siteConfig.Post.AddMetaKeywordsAsTag;
                this.SaveMetaDescriptionCb.Checked = siteConfig.Post.SaveMetaDescription;
                this.SaveFeaturedImagesPostCb.Checked = siteConfig.Post.SaveFeaturedImages;
                this.PostFeaturedImageSelectorTb.Text = siteConfig.Post.FeaturedImageSelector;
                this.PaginatePostsCb.Checked = siteConfig.Post.PaginatePosts;
                this.PostNextPageURLSelectorTb.Text = siteConfig.Post.PostNextPageURLSelector;
                this.PostFindAndReplaceRawHTMLTb.Text = siteConfig.Post.FindAndReplaceRawHTML;
                this.PostRemoveElementAttributesTb.Text = siteConfig.Post.RemoveElementAttributes;
                this.PostUnnecessaryElementsTb.Text = siteConfig.Post.UnnecessaryElements;
            }

            SetShowTypeCrawler();
            SetSettingExport(siteConfig);
        }

        private void SetSettingExport(SiteConfig siteConfig)
        {
            this.ExportSettingTb.Text = Helper.ObjectToString(siteConfig);
        }

        private void SetShowTypeCrawler()
        {
            if (IsCrawleUrls())
            {
                ShowCrawlerUrls(true);
                ShowCategoryPage(false);
            }
            else
            {
                ShowCrawlerUrls(false);
                ShowCategoryPage(true);
            }
        }

        private bool IsCrawleUrls()
        {
            return this.ListUrlRb.Checked && !this.CategoryPageRb.Checked;
        }

        private void ShowCrawlerUrls(bool isShow)
        {
            if (isShow)
            {
                this.CrawlerUrlsTb.Show();
                this.CrawlerUrlsLb.Show();
            }
            else
            {
                this.CrawlerUrlsTb.Hide();
                this.CrawlerUrlsLb.Hide();
            }
        }

        private void ShowCategoryPage(bool isShow)
        {
            if (isShow)
            {
                this.CategoryListPageURLLb.Show();
                this.CategoryListPageURLTb.Show();
                this.CategoryListURLSelectorLb.Show();
                this.CategoryListURLSelectorTb.Show();
                this.CategoryPostUrlTb.Show();
                this.CategoryPostUrlLb.Show();
                this.CategoryPostURLSelectorTb.Show();
                this.CategoryPostURLSelectorLb.Show();
                this.CategoryNextPageURLSelectorTb.Show();
                this.CategoryNextPageURLSelectorLb.Show();
                this.CategoryDescriptionTb.Show();
                this.CategoryDescriptionLb.Show();
            }
            else
            {
                this.CategoryListPageURLLb.Hide();
                this.CategoryListPageURLTb.Hide();
                this.CategoryListURLSelectorLb.Hide();
                this.CategoryListURLSelectorTb.Hide();
                this.CategoryPostUrlLb.Hide();
                this.CategoryPostUrlTb.Hide();
                this.CategoryPostURLSelectorTb.Hide();
                this.CategoryPostURLSelectorLb.Hide();
                this.CategoryNextPageURLSelectorLb.Hide();
                this.CategoryNextPageURLSelectorTb.Hide();
                this.CategoryDescriptionTb.Hide();
                this.CategoryDescriptionLb.Hide();
            }
        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;

            if (string.IsNullOrEmpty(this.ImportSettingTb.Text))
            {
                var site = SetSiteConfig(_siteConfig);
                site.UpdateTime = now;
                await this._siteRepository.UpdateAsync(site);

                var category = SetCategoryConfig(_siteConfig.Category);
                category.UpdateTime = now;
                await this._categoryRepository.UpdateAsync(category);

                var post = SetPostConfig(_siteConfig.Post);
                post.UpdateTime = now;
                await this._postRepository.UpdateAsync(post);
            }
            else
            {
                var siteConfig = Helper.StringToObject(this.ImportSettingTb.Text) as SiteConfig;
                siteConfig.Id = _siteConfig.Id;
                siteConfig.UpdateTime = now;
                siteConfig.LastPostCrawl = null;
                siteConfig.Name = string.IsNullOrEmpty(this.NameTb.Text) ? string.Format("{0}_copy_{1}", siteConfig.Name, DateTime.Now) : this.NameTb.Text;
                siteConfig.IsDone = false;
                siteConfig.CategoryNextPageURL = null;

                siteConfig.Category.Id = _siteConfig.Category.Id;
                _siteConfig.Category.UpdateTime = now;
                siteConfig.Post.Id = _siteConfig.Post.Id;
                _siteConfig.Post.UpdateTime = now;

                await this._siteRepository.UpdateAsync(siteConfig);
            }

            _backToListSite();
        }

        private async void CreateBtn_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            if (string.IsNullOrEmpty(this.ImportSettingTb.Text))
            {
                var site = SetSiteConfig(new SiteConfig
                {
                    UpdateTime = now,
                    CreateTime = now
                });
                await this._siteRepository.AddAsync(site);

                var category = SetCategoryConfig(new CategoryConfig
                {
                    SiteID = site.Id,
                    UpdateTime = now,
                    CreateTime = now
                });
                await this._categoryRepository.AddAsync(category);

                var post = SetPostConfig(new PostConfig
                {
                    SiteID = site.Id,
                    UpdateTime = now,
                    CreateTime = now
                });
                await this._postRepository.AddAsync(post);
            }
            else // case import settings
            {
                var siteConfig = Helper.StringToObject(this.ImportSettingTb.Text) as SiteConfig;
                siteConfig.Id = 0;
                siteConfig.CreateTime = now;
                siteConfig.UpdateTime = now;
                siteConfig.LastPostCrawl = null;
                siteConfig.Name = string.IsNullOrEmpty(this.NameTb.Text) ? string.Format("{0}_copy_{1}", siteConfig.Name, DateTime.Now) : this.NameTb.Text;
                siteConfig.IsDone = false;
                siteConfig.CategoryNextPageURL = null;

                var category = siteConfig.Category;
                category.Site = null;
                category.CreateTime = now;
                category.UpdateTime = now;
                category.Id = 0;

                var post = siteConfig.Post;
                post.Site = null;
                post.Id = 0;
                post.CreateTime = now;
                post.UpdateTime = now;

                siteConfig.Post = null;
                siteConfig.Category = null;
                await this._siteRepository.AddAsync(siteConfig);

                category.SiteID = siteConfig.Id;
                await this._categoryRepository.AddAsync(category);

                post.SiteID = siteConfig.Id;
                await this._postRepository.AddAsync(post);
            }

            _backToListSite();
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            _backToListSite();
        }

        private void ListUrlRb_CheckedChanged(object sender, EventArgs e)
        {
            SetShowTypeCrawler();
        }

        private void CategoryPageRb_CheckedChanged(object sender, EventArgs e)
        {
            SetShowTypeCrawler();
        }

        private SiteConfig SetSiteConfig(SiteConfig siteConfig)
        {
            siteConfig.Name = this.NameTb.Text;
            siteConfig.Url = this.UrlTxt.Text;
            siteConfig.ActiveForScheduling = this.ActiveForSchedulingCb.Checked;
            siteConfig.IsTryTest = this.IsTryTestCb.Checked;
            siteConfig.IsPageUrl = IsCrawleUrls();
            siteConfig.CheckDuplicatePostViaContent = this.CheckDuplicatePostViaContentCb.Checked;
            siteConfig.CheckDuplicatePostViaTitle = this.CheckDuplicatePostViaTitleCb.Checked;
            siteConfig.CheckDuplicatePostViaUrl = this.CheckDuplicatePostViaUrlCb.Checked;
            siteConfig.MaximumPagesCrawlPerCategory = (int)this.MaximumPagesCrawlPerCategoryNumeric.Value;
            siteConfig.MaximumPagesCrawlPerPost = (int)this.MaximumPagesCrawlPerPostNumeric.Value;
            siteConfig.HTTPUserAgent = this.HTTPUserAgentTb.Text;
            siteConfig.ConnectionTimeout = (int)this.connectionTimeoutNumeric.Value;
            siteConfig.ActiveForPostSpinning = this.ActiveForPostSpinningCb.Checked;
            siteConfig.ActiveForPostTranslation = this.ActiveForPostTranslationCb.Checked;
            siteConfig.UseProxy = this.UseProxyCb.Checked;
            siteConfig.Proxies = this.ProxiesTb.Text;
            siteConfig.RandomizeProxies = this.RandomizeProxiesCb.Checked;
            siteConfig.TimeInterval = (int)this.TimeIntervalNumeric.Value;
            siteConfig.Notes = this.NoteTb.Text;
            siteConfig.Cookie = this.CookieCb.Text;
            siteConfig.ProxyRetryLimit = (int)this.ProxyRetryLimitNumeric.Value;
            siteConfig.WordpressApiUrl = this.WordpressApiUrlTb.Text;
            siteConfig.WordpressUserName = this.WordpressUserNameTb.Text;
            siteConfig.WordpressApplicationPW = this.WordpressApplicationPWTb.Text;
            return siteConfig;
        }

        private CategoryConfig SetCategoryConfig(CategoryConfig categoryConfig)
        {
            categoryConfig.CategoryMap = this.CategoryMapTb.Text;
            categoryConfig.SaveFeaturedImages = this.SaveFeaturedImagesCb.Checked;
            categoryConfig.FeaturedImageSelector = this.FeaturedImageSelectorTb.Text;
            categoryConfig.FindAndReplaceRawHTML = this.FindAndReplaceRawHTMLTb.Text;
            categoryConfig.RemoveElementAttributes = this.RemoveElementAttributesTb.Text;
            categoryConfig.UnnecessaryElements = this.UnnecessaryElementsTb.Text;
            categoryConfig.Description = this.CategoryDescriptionTb.Text;

            if (IsCrawleUrls())
            {
                categoryConfig.Urls = this.CrawlerUrlsTb.Text;
            }
            else
            {
                categoryConfig.CategoryListPageURL = this.CategoryListPageURLTb.Text;
                categoryConfig.CategoryListURLSelector = this.CategoryListURLSelectorTb.Text;
                categoryConfig.CategoryPostURL = this.CategoryPostUrlTb.Text;
                categoryConfig.CategoryPostURLSelector = this.CategoryPostURLSelectorTb.Text;
                categoryConfig.CategoryNextPageURLSelector = this.CategoryNextPageURLSelectorTb.Text;
            }

            return categoryConfig;
        }

        private PostConfig SetPostConfig(PostConfig postConfig)
        {
            postConfig.PostFormat = this.PostFormatCb.Text;
            postConfig.PostType = this.PostTypeCb.Text;
            postConfig.PostAuthor = this.PostAuthorTb.Text;
            postConfig.PostStatus = this.PostStatusCb.Text;
            postConfig.PostTitleSelector = this.PostTitleSelectorTb.Text;
            postConfig.PostExcerptSelector = this.PostExcerptSelectorTb.Text;
            postConfig.PostContentSelector = this.PostContentSelectorTb.Text;
            postConfig.PostTagSelector = this.PostTagSelectorTb.Text;
            postConfig.PostSlugSelector = this.PostSlugSelectorTb.Text;
            postConfig.CategoryNameSelector = this.CategoryNameSelectorTb.Text;
            postConfig.CategoryNameSeparatorSelector = this.CategoryNameSeparatorSelectorTb.Text;
            postConfig.PostDateSelector = this.PostDateSelectorTb.Text;
            postConfig.SaveMetaKeywords = this.SaveMetaKeywordsCb.Checked;
            postConfig.AddMetaKeywordsAsTag = this.AddMetaKeywordsAsTagCb.Checked;
            postConfig.SaveMetaDescription = this.SaveMetaDescriptionCb.Checked;
            postConfig.SaveFeaturedImages = this.SaveFeaturedImagesPostCb.Checked;
            postConfig.FeaturedImageSelector = this.PostFeaturedImageSelectorTb.Text;
            postConfig.PaginatePosts = this.PaginatePostsCb.Checked;
            postConfig.PostNextPageURLSelector = this.PostNextPageURLSelectorTb.Text;
            postConfig.FindAndReplaceRawHTML = this.PostFindAndReplaceRawHTMLTb.Text;
            postConfig.RemoveElementAttributes = this.PostRemoveElementAttributesTb.Text;
            postConfig.UnnecessaryElements = this.PostUnnecessaryElementsTb.Text;
            return postConfig;
        }
    }
}