using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.ViewModels
{
    public class CartItemViewModel
    {
        public int? idCartItem { get; set; }
        public int? idCart { get; set; }
        public int? idProduct { get; set; }
        public int? quantity { get; set; }
        public string noteProduct { get; set; }
        public string status { get; set; }
    }
}
