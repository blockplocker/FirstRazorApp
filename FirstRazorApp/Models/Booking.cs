using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace FirstRazorApp.Models
{
    public class Booking
    {
        [BindProperty]
        [Required]
        [Display(Name = "Förnamn")]
        public string FirstName { get; set; }
        [BindProperty]
        [Required]
        [Display(Name = "Efternamn")]
        public string LastName { get; set; }
        [BindProperty]
        [Required]
        [Display(Name = "Res datum")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [BindProperty]
        [Required]
        [Display(Name = "Retur datum")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        [BindProperty]
        [Required]
        [Display(Name = "Antal väskor")]
        public int NumberOfBags { get; set; }
        [BindProperty]
        [Required]
        [Display(Name = "Antal liter vatten")]
        public int LitersOfWater { get; set; }
        [BindProperty]
        [Required]
        [Display(Name = "Antal måltider")]
        public int NumberOfMeals { get; set; }
        [BindProperty]
        [Display(Name = "Lyxhytt")]
        public bool LuxuryRoom { get; set; }
        [BindProperty]
        [Display(Name = "Färg på hyttväggen")]
        public string RoomColor { get; set; }
    }
}
