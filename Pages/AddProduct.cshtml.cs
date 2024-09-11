using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopEasy.Context;
using ShopEasy.Models;

namespace ShopEasy.Pages
{
    public class AddProductModel : PageModel
    {
        private readonly AppDbContext _context;
        [BindProperty]       
        public Product? Product { get; set; }
        
        public AddProductModel(AppDbContext context)
        {
            _context = context;
        }
        //public void OnGet()
        //{
        //}
        
        public async Task<IActionResult> OnPostAsync() 
        {
            var value = $"{Product?.Name} - {Product?.Price} - {Product?.Description}";
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Product != null)
            {
                _context.Products.Add(Product);
                await _context.SaveChangesAsync();
            }

            return Redirect("/Products");
            
        }
    }
}
