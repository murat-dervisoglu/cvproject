using entitylayer.concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace entitylayer.concrete
{
    public class feature
    {
        [Key]
        public int featureID { get; set; }
        public string header { get; set; }
        public string name { get; set; }
        public string title { get; set; }

    }
}
