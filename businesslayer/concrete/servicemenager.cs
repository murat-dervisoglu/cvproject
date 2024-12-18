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
    public class servicemenager : Iserviceservice
    {
        Iservicedal _serviceDal;

        public servicemenager(Iservicedal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Tadd(service t)
        {
            _serviceDal.insert(t);
        }

        public void Tdelete(service t)
        {
            _serviceDal.delete(t);
        }

        public service TGetByID(int id)
        {
            return _serviceDal.GetByID(id);
        }

        public List<service> TGetList()
        {
            return _serviceDal.Getlist();
        }

        public List<service> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(service t)
        {
            _serviceDal.update(t);
        }
    }
}
