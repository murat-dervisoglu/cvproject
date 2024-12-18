using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayer.concrete
{
    public class portfolio
    {
        [Key]
        public int portfolioID  { get; set; }
        public  string name { get; set; }
        public string imageUrl { get; set; }
        public string projectrl { get; set; }
        public string imageUrl2 { get; set; }
        public string platform { get; set;}
        public string price { get; set;}
        public bool satutus { get; set;}
        public string image1 { get; set;}
        public string image2 { get; set;}
        public string image3 { get; set;}
        public string image4 { get; set;}
        public int value { get; set;}
    }
}
