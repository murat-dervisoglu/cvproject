using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayer.concrete
{
    public class service
    {
        [Key]
        public int serviceID { get; set; }
        public  string title { get; set; }
        public  string imageUrl { get; set; }
    }
}
