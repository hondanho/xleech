﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XLeech.Data.EntityFramework;

#nullable disable

namespace XLeech.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240412010836_update_site_config")]
    partial class update_site_config
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("XLeech.Data.Entity.CategoryConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryListPageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryListURLSelector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryMap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryNextPageURLSelector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryPostURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryPostURLSelector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeaturedImageSelector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FindAndReplaceRawHTML")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemoveElementAttributes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SaveFeaturedImages")
                        .HasColumnType("bit");

                    b.Property<int>("SiteID")
                        .HasColumnType("int");

                    b.Property<string>("UnnecessaryElements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Urls")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SiteID")
                        .IsUnique();

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("XLeech.Data.Entity.PostConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("AddMetaKeywordsAsTag")
                        .HasColumnType("bit");

                    b.Property<string>("CategoryNameSelector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryNameSeparatorSelector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FeaturedImageSelector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FindAndReplaceRawHTML")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PaginatePosts")
                        .HasColumnType("bit");

                    b.Property<string>("PostAuthor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostContentSelector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostDateSelector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostExcerptSelector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostFormat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostNextPageURLSelector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostSlugSelector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostTagSelector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostTitleSelector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemoveElementAttributes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SaveFeaturedImages")
                        .HasColumnType("bit");

                    b.Property<bool>("SaveMetaDescription")
                        .HasColumnType("bit");

                    b.Property<bool>("SaveMetaKeywords")
                        .HasColumnType("bit");

                    b.Property<int>("SiteID")
                        .HasColumnType("int");

                    b.Property<string>("UnnecessaryElements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SiteID")
                        .IsUnique();

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("XLeech.Data.Entity.SiteConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("ActiveForPostSpinning")
                        .HasColumnType("bit");

                    b.Property<bool>("ActiveForPostTranslation")
                        .HasColumnType("bit");

                    b.Property<bool>("ActiveForScheduling")
                        .HasColumnType("bit");

                    b.Property<string>("CategoryNextPageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CheckDuplicatePostViaContent")
                        .HasColumnType("bit");

                    b.Property<bool>("CheckDuplicatePostViaTitle")
                        .HasColumnType("bit");

                    b.Property<bool>("CheckDuplicatePostViaUrl")
                        .HasColumnType("bit");

                    b.Property<int>("ConnectionTimeout")
                        .HasColumnType("int");

                    b.Property<string>("Cookie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("HTTPUserAgent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPageUrl")
                        .HasColumnType("bit");

                    b.Property<string>("LastPostCrawl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LatestRun")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MaximumPagesCrawlPerCategory")
                        .HasColumnType("int");

                    b.Property<int?>("MaximumPagesCrawlPerPost")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Proxies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProxyRetryLimit")
                        .HasColumnType("int");

                    b.Property<bool>("RandomizeProxies")
                        .HasColumnType("bit");

                    b.Property<int>("TimeInterval")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UseProxy")
                        .HasColumnType("bit");

                    b.Property<string>("WordpressApiUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WordpressApplicationPW")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WordpressUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("XLeech.Data.Entity.CategoryConfig", b =>
                {
                    b.HasOne("XLeech.Data.Entity.SiteConfig", "Site")
                        .WithOne("Category")
                        .HasForeignKey("XLeech.Data.Entity.CategoryConfig", "SiteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Site");
                });

            modelBuilder.Entity("XLeech.Data.Entity.PostConfig", b =>
                {
                    b.HasOne("XLeech.Data.Entity.SiteConfig", "Site")
                        .WithOne("Post")
                        .HasForeignKey("XLeech.Data.Entity.PostConfig", "SiteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Site");
                });

            modelBuilder.Entity("XLeech.Data.Entity.SiteConfig", b =>
                {
                    b.Navigation("Category")
                        .IsRequired();

                    b.Navigation("Post")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
