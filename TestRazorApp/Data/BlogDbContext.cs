using Microsoft.EntityFrameworkCore;
using TestRazorApp.Models;

namespace TestRazorApp.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        { /*constructor*/

        }

        public DbSet<Article> Articles { get; set; }
    }
}
