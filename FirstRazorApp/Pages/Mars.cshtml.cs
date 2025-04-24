using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace FirstRazorApp.Pages
{
    public class MarsModel : PageModel
    {
        [BindProperty]
        [Display(Name ="Förnamn")]
        public string FirstName { get; set; }
        [BindProperty]
        [Display(Name = "Efternamn")]
        public string LastName { get; set; }
        [BindProperty]
        [Display(Name = "Res datum")]
        public DateTime StartDate { get; set; }
        [BindProperty]
        [Display(Name = "Retur datum")]
        public DateTime EndDate { get; set; }
        [BindProperty]
        [Display(Name = "Antal väskor")]
        public int NumberOfBags { get; set; }
        [BindProperty]
        [Display(Name = "Antal liter vatten")]
        public int LitersOfWater { get; set; }
        [BindProperty]
        [Display(Name = "Antal måltider")]
        public int NumberOfMeals { get; set; }
        [BindProperty]
        [Display(Name = "Lyxhytt")] 
        public bool LuxuryRoom { get; set; }
        [BindProperty]
        [Display(Name = "Färg på hyttväggen")]
        public string RoomColor { get; set; }

        public void OnGet()
        {
        }
    }
}
