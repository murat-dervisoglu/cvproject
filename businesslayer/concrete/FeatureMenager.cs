using businesslayer.Abstract;
using dataaccesslayer.asbtract;
using entitylayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businesslayer.concrete
{
    public class FeatureMenager : Igenericservice<feature>
    {
        Ifeaturedal _featuredal;

        public FeatureMenager(Ifeaturedal featuredal)
        {
            _featuredal = featuredal;
        }

        public void Tadd(feature t)
        {
            _featuredal.insert(t);
        }

        public void Tdelete(feature t)
        {
            _featuredal.delete(t);
        }

        public feature TGetByID(int id)
        {
            return _featuredal.GetByID(id);
        }

        public List<feature> TGetList()
        {
            return _featuredal.Getlist();
        }

        public List<feature> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(feature t)
        {
            _featuredal.update(t);
        }
    }
}
