﻿
namespace XLeech.Data.Entity
{

    [Serializable]
    public class PostConfig: BaseEntity
    {
        public int SiteID { get; set; }
        public string? PostFormat { get; set; }
        public string? PostStatus { get; set; }
        public string? PostType { get; set; }
        public string? PostAuthor { get; set; }
        public string? PostTitleSelector { get; set; }
        /// <summary>
        /// Đoạn trích
        /// </summary>
        public string? PostExcerptSelector { get; set; }
        public string? PostContentSelector { get; set; }
        public string? PostTagSelector { get; set; }
        public string? PostSlugSelector { get; set; }
        public string? CategoryNameSelector { get; set; }
        /// <summary>
        /// ngăn cách category ;
        /// </summary>
        public string? CategoryNameSeparatorSelector { get; set; }
        public string? PostDateSelector { get; set; }
        public bool SaveMetaKeywords { get; set; }
        public bool AddMetaKeywordsAsTag { get; set; }
        public bool SaveMetaDescription { get; set; }
        public bool SaveFeaturedImages { get; set; }
        public string? FeaturedImageSelector { get; set; }
        public bool PaginatePosts { get; set; }
        public string? PostNextPageURLSelector { get; set; }
        public string? FindAndReplaceRawHTML { get; set; }
        public string? RemoveElementAttributes { get; set; }
        public string? UnnecessaryElements { get; set; }
        public SiteConfig Site { get; set; }
    }
}