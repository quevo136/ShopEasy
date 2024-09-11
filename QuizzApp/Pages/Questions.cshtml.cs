using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuizzApp.Context;
using QuizzApp.Models;
using QuizzApp.Services;

namespace QuizzApp.Pages
{
    public class QuestionsModel : PageModel
    {
        //private AppDbContext _context;
        public List<Question> Questions { get; set; }

        private AppDbContext _context {  get; set; }
        public QuestionsModel(AppDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Questions = _context.Questions.ToList();
            
        }
    }
}
