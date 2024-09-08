using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ShopEasy.Pages
{
    public class ProductDetailsModel : PageModel
    {

        public string Name { get; set; }
        public string Image {  get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }    

        public void OnGet()
        {
        }


    }
}
