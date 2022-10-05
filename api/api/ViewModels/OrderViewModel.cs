using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.ViewModels
{
    public class OrderViewModel
    {
        public int? idOrder { get; set; }
        public int? idCart { get; set; }
        public string status { get; set; }
        public string timeUserAddress { get; set; }
    }
}
