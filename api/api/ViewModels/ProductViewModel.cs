using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.ViewModels
{
    public class ProductViewModel
    {
        public int? idProduct { get; set; }
        public string category { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public decimal? price { get; set; }
        public int? nStars { get; set; }
        public int? idRestaurant { get; set; }
        public string allergens { get; set; }
        public string mainIngredients { get; set; }
        public string nutritionalValue { get; set; }
        
    }
}
