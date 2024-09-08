using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopEasy.Context;
using ShopEasy.Models;

namespace ShopEasy.Pages
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        
        public Product? Product { get; set; }
        private AppDbContext _context {  get; set; }
        public AddProductModel(AppDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
        
        public IActionResult OnPost() 
        {
            var value = $"{Product?.Name} - {Product?.Price} - {Product?.Description}";
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Products.Add(Product);
            _context.SaveChanges();

            return Redirect("/Products");
            
        }
    }
}
