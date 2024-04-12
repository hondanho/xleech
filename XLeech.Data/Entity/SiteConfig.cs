﻿
using WordPressPCL.Models;

namespace XLeech.Data.Entity
{

    [Serializable]
    public class SiteConfig: BaseEntity
    {
        public string? Name { get; set; }
        public bool IsDone { get; set; }
        public string? Url { get; set; }
        public bool IsPageUrl {get;set;}
        public bool ActiveForScheduling { get; set; }
        public bool CheckDuplicatePostViaUrl { get; set; }
        public bool CheckDuplicatePostViaTitle { get; set; }
        public bool CheckDuplicatePostViaContent { get; set; }
        public int? MaximumPagesCrawlPerCategory { get; set; }
        public int? MaximumPagesCrawlPerPost { get; set; }
        public string? HTTPUserAgent { get; set; }
        public string? Cookie { get; set; }
        public int ConnectionTimeout { get; set; }
        public bool UseProxy { get; set; }
        /// <summary>
        /// New line seprated proxies
        /// </summary>
        public string? Proxies { get; set; }
        public int ProxyRetryLimit { get; set; }
        public bool RandomizeProxies { get; set; }
        public int TimeInterval { get; set; }
        public DateTime? LatestRun { get; set; }
        public string? CategoryNextPageURL { get; set; }
        public string? LastPostCrawl { get; set; }
        public string? Notes { get; set; }
        public string? WordpressApiUrl { get; set; }
        public string? WordpressUserName { get; set; }
        public string? WordpressApplicationPW { get; set; }
        public bool ActiveForPostTranslation { get; set; }
        public bool ActiveForPostSpinning { get; set; }
        public CategoryConfig Category { get; set; }
        public PostConfig Post { get; set; }
    }
}