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
    public class aboutmenager : Iaboutservice
    {
        Iaboutdal _aboutdal;

        public aboutmenager(Iaboutdal aboutdal)
        {
            _aboutdal = aboutdal;
        }

        public void Tadd(about t)
        {
            _aboutdal.insert(t);
        }

        public void Tdelete(about t)
        {
            _aboutdal.delete(t);
        }

        public about TGetByID(int id)
        {
            return _aboutdal.GetByID(id);
        }

        public List<about> TGetList()
        {
            return _aboutdal.Getlist();
        }

        public List<about> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(about t)
        {
            _aboutdal.update(t);
        }
    }
}
