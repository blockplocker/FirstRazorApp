using FirstRazorApp.Models;

namespace FirstRazorApp.Extenstions
{
    public static class BookingExtensions
    {
        public static int CalculatePrice(this Booking source)
        {
            int days = (source.EndDate - source.StartDate).Days;
            return (days * 24000) + (source.NumberOfBags * 5000) +
                   (source.LitersOfWater * 150) + (source.NumberOfMeals * 495) +
                   (source.LuxuryRoom ? 150000 : 0);
        }
    }
}
