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
    public class ContactMenager: Icontactservice
    {
        Icontactdal _contacdal;

        public ContactMenager(Icontactdal contacdal)
        {
            _contacdal = contacdal;
        }

        public void Tadd(contact t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(contact t)
        {
            throw new NotImplementedException();
        }

        public contact TGetByID(int id)
        {
            return _contacdal.GetByID(id);
        }

        public List<contact> TGetList()
        {
            return _contacdal.Getlist();
        }

        public List<contact> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(contact t)
        {
            _contacdal.update(t);
        }
    }
}
