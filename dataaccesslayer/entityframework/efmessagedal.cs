using dataaccesslayer.asbtract;
using dataaccesslayer.repository;
using entitylayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataaccesslayer.entityframework
{
    public class efmessagedal: genericrepository<message>,Imessagedal
    {
    }
}
