using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.ViewModels
{
    public class LogViewModel
    {
        public int? idLog { get; set; }
        public DateTime? dateTime { get; set; }
        public int? idUser { get; set; }
        public string type { get; set; }
        public string titleLog { get; set; }
        public string resume { get; set; }
        public string status { get; set; }
    }
}
