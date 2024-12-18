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
    public class MessageMenager : Imessageservice
    {
         Imessagedal _messagedal;

        public MessageMenager(Imessagedal messagedal)
        {
            _messagedal = messagedal;
        }

        public void Tadd(message t)
        {
            _messagedal.insert(t);
        }

        public void Tdelete(message t)
        {
            _messagedal.delete(t);
        }

        public message TGetByID(int id)
        {
            return _messagedal.GetByID(id);
        }

        public List<message> TGetList()
        {
            return _messagedal.Getlist();
        }

        public List<message> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(message t)
        {
            throw new NotImplementedException();
        }
    }
}
