using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopEasy.Models;

namespace ShopEasy.Pages
{
    public class Products : PageModel
    {

        public List<Product> _Products { get; set; }
        public void OnGet()
        {
            _Products = new List<Product>()
            {
                new Product()        
                {
                    Id = 1,
                    Name = "Bicycle",
                    Price = 900,
                    Description = "good"


                },
                new Product()
                {
                    Id = 2,
                    Name = "video",
                    Price = 900,
                    Description = "bad"
                },

                new Product()
                {
                    Id = 3,
                    Name = "Book",
                    Price = 100,
                    Description = "oki"
                },

            };

        }
    }
}
