using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestRazorApp.Data;
using TestRazorApp.Models;

namespace TestRazorApp.Pages.Articles
{
    public class EditModel : PageModel
    {
        private readonly BlogDbContext _context;

        public EditModel(BlogDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Article> Articles { get; set; }
        public void OnGet()
        {

        }
    }
}
