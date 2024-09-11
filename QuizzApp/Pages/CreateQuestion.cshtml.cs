using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using QuizzApp.Context;
using QuizzApp.Models;

namespace QuizzApp.Pages
{
    public class CreateQuestionModel : PageModel
    {
        private readonly AppDbContext _service;

        [BindProperty]
        public Question? Question { get; set; }

        public CreateQuestionModel(AppDbContext service)
        {
            _service = service;
        }

        public void OnGet()
        {
                      
        }

        public async Task<IActionResult> OnPost()
        {
            var value = $"{Question.Text}";

            if (!ModelState.IsValid)
            {
                return Page();
            }
            try
            {
                _service.Questions.Add(Question);
                
                await _service.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Log exception (e.g., use ILogger or another logging mechanism)
                ModelState.AddModelError(string.Empty, "An error occurred while saving data.");
                return Page();
            }

            //if (Question != null)
            //{
                 
            //    _service.Questions.Add(Question);
            //    await _service.SaveChangesAsync();
            //}
           
            return Redirect("/Index"); // Adjust to your needs
        }
    }

    
}
