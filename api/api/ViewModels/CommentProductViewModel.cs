using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.ViewModels
{
    public class CommentProductViewModel
    {
        public int? idCommentProduct { get; set; }
        public string image { get; set; }
        public string nameClient { get; set; }
        public int? nStars { get; set; }
        public int? idProduct { get; set; }
        public string text { get; set; }
        public string status { get; set; }
    }
}
