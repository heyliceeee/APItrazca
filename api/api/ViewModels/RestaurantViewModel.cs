using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.ViewModels
{
    public class RestaurantViewModel
    {
        public int idRestaurant { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public int? nStars { get; set; }
        public string allCategories { get; set; }
        public decimal? cheapPriceProduct { get; set; }
        public decimal? distanceUserAddress { get; set; }
        public string description { get; set; }

    }
}
