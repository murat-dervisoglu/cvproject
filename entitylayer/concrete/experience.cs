using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayer.concrete
{
    public class experience
    {
        [Key]
        public int experienceId { get; set; }
        public  string name { get; set; }
        public string date { get; set; }
        public string imageUrl { get; set; }
        public string description { get; set; }
   
    }
}
