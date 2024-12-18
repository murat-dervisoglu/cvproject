using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayer.concrete
{
    public class testimonial
    {
        [Key]
        public int testimonialID { get; set; }
        public string clientname { get; set; }
        public string company { get; set; }
        public  string comment { get; set; }
        public string imageUrl { get; set; }
        public string Title { get; set; }    
    
    }
}
