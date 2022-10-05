using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.ViewModels
{
    public class CartViewModel
    {
        public int? idCart { get; set; }
        public int? idUser { get; set; }
        public decimal? subtotal { get; set; }
        public decimal? deliveryFee { get; set; }
        public decimal? discount { get; set; }
        public decimal? total { get; set; }
        public string status { get; set; }
    }
}
