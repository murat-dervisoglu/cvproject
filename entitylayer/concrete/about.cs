using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayer.concrete
{
    public class about
    {
        [Key]
        public int AboutID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public  string age { get; set; }
        public  string mail { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string imageUrl { get; set; }
    }
}
