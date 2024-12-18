using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayer.concrete
{
    public class contact
    {
        [Key]
        public  int concactID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public  string mail { get; set; }
        public  string phonenumber { get; set; }
    
    }
}
