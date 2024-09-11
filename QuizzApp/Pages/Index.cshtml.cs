using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using QuizzApp.Context;
using QuizzApp.Models;

namespace QuizzApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _logger;

        public IndexModel(AppDbContext logger)
        {
            
            _logger = logger;
        }

        public IEnumerable<Question> displayresult { get; set; }

        public async Task OnGet()
        {
            displayresult= await _logger.Questions.ToListAsync();

        }
    }
}
