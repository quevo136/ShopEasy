using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ShopEasy.Pages
{
    public class CartModel : PageModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            var value = $"{Name} - {Price} - {Quantity}";

            return Page();
            //return Redirect("/Products");


        }
    }
}
