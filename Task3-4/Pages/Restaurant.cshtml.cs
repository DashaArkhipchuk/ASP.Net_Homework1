
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataClasses;

namespace Task3_4.Pages
{
    public class RestaurantModel : PageModel
    {
        public List<Restaurant> Restaurants { get; private set; }

        public void OnGet()
        {
            Restaurants = new List<Restaurant>();

            for (int i = 1; i <= 15; i++)
            {
                Restaurants.Add(new Restaurant
                {
                    Id = i,
                    Name = "Restaurant " + i,
                    Address = "Address " + i
                });
            }
        }
    }
}
