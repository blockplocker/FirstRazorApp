using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstRazorApp.Pages
{
    public class MultiplicationModel : PageModel
    {
        public int? SelectedNumber { get; set; }
        public void OnGet(int number)
        {
            if(number != 0)
            {
                SelectedNumber = number;
            }
        }
    }
}
