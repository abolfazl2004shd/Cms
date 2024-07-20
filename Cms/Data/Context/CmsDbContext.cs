using Cms.Models;
using Microsoft.EntityFrameworkCore;

namespace Cms.Data.Context
{
    public class CmsDbContext(DbContextOptions<CmsDbContext> options) : DbContext(options)
    {
        public DbSet<Page> Pages { get; set; }
        public DbSet<PageGroup> PageGroups { get; set; }
        public DbSet<PageComment> PageComments { get; set; }
    }
}
