﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayer.concrete
{
    public class socialmedia
    {
        [Key]
        public int socialmediaID { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string icon { get; set; }
        public bool status { get; set; }
    }
}
