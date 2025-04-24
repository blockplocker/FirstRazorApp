using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstRazorApp.Pages
{
    public class SpringModel : PageModel
    {
        public string MinText2 { get; set; }
        public string ImgSrc { get; set; }
        public void OnGet()
        {
            MinText2 = "Hejsan, från code behind";

            ImgSrc = "img/spring" + Random.Shared.Next(1, 3) + ".jpg";
        }
    }
}
