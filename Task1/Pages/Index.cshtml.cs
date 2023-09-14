using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Task1.Pages
{
    public class IndexModel:PageModel
    {
        public int DayOfYear { get; private set; }
        public void OnGet()
        {
            DayOfYear = DateTime.Now.DayOfYear;
        }
    }
}
