using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstRazorApp.Pages
{
    public class IndexModel : PageModel
    {
        public Models.Booking? Booking { get; set; }

        public void OnGet()
        {
        }
        public void OnPost(Models.Booking booking)
        {
            if (ModelState.IsValid)
            {
            Booking = booking;
            }
        }
    }
}
