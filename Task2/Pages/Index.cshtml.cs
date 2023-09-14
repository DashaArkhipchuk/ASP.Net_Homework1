using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Task2.Pages
{
    public class IndexModel : PageModel
    {
        public char RandomLetter { get; set; }

        public void OnGet()
        {
            Random random = new Random();
            RandomLetter = (char)('A' + random.Next(26));
        }
    }
}