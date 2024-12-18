using dataaccesslayer.asbtract;
using dataaccesslayer.repository;
using entitylayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataaccesslayer.entity_framework
{
    public class efaboutdal: genericrepository<about>,Iaboutdal
    {
    }
}
