using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using XLeech.Data.Entity;

namespace XLeech.Data.EntityFramework
{
    public class AppDbContext : ThreadSafeDbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = configuration.GetConnectionString("XLeech");
                optionsBuilder.UseSqlServer(connectionString);
                base.OnConfiguring(optionsBuilder); // don't forget to call the base method
            }
        }

        public virtual DbSet<SiteConfig> Sites { get; set; }
        public virtual DbSet<CategoryConfig> Categories { get; set; }
        public virtual DbSet<PostConfig> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SiteConfig>()
                .HasOne(u => u.Category)
                .WithOne(up => up.Site)
                .HasForeignKey<CategoryConfig>(up => up.SiteID);

            modelBuilder.Entity<SiteConfig>()
                .HasOne(u => u.Post)
                .WithOne(up => up.Site)
                .HasForeignKey<PostConfig>(up => up.SiteID);
        }
    }
}
