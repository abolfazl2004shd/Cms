using Cms.Models;
using Microsoft.EntityFrameworkCore;

namespace Cms.Data.Context
{
    public class CmsDbContext : DbContext
    {
        public CmsDbContext(DbContextOptions<CmsDbContext> options) : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("CmsContextConnection");
            }
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleGroup> ArticleGroups { get; set; }
        public DbSet<ArticleComment> ArticleComments { get; set; }
        public DbSet<Keyword> Keywords { get; set; }
    }
}
