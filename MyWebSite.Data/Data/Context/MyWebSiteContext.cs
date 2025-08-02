using Microsoft.EntityFrameworkCore;
using MyWebSite.Domain.Entities.Admin;
using MyWebSite.Domain.Entities.Blog;
using MyWebSite.Domain.Entities.Cartoon;
using MyWebSite.Domain.Entities.WebSite;

namespace MyWebSite.Infrastructure.Data.Context
{
    public class MyWebSiteContext : DbContext
    {
        public MyWebSiteContext(DbContextOptions<MyWebSiteContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<BlogCategoryPost> BlogCategoryPosts { get; set; }
        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<CartoonCategoryPost> CartoonCategoryPosts { get; set; }
        public DbSet<CartoonPost> CartoonPosts { get; set; }
        public DbSet<WebSiteDescription> WebSiteDescriptions { get; set; }
        public DbSet<WebSiteGeral> WebSiteGerals { get; set; }
        public DbSet<WebSiteknowledge> WebSiteknowledges { get; set; }
        public DbSet<WebSiteSkill> WebSiteSkills { get; set; }
        public DbSet<WebSiteSocialMedia> WebSiteSocialMedias { get; set; }
        public DbSet<WebSiteTestemonial> WebSiteTestemonials { get; set; }
        public DbSet<WebSiteSkillDescription> WebSiteSkillDescriptions { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
