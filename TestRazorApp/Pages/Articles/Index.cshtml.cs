using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestRazorApp.Data;
using TestRazorApp.Models;

namespace TestRazorApp.Pages.Articles
{
    public class IndexModel : PageModel
    {
        private readonly BlogDbContext _context;
        public IndexModel(BlogDbContext context)//constructor, executed by default
        {
            _context = context;
        }
        public IEnumerable<Article> Articles { get; set; }//property
        public void OnGet()
        {
            Articles = _context.Articles;   
        }
    }
}
