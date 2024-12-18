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
    public class PortfolioManager : Iportfolioservice
    {
        Iportfoliodal _portfoliodal;

        public PortfolioManager(Iportfoliodal portfoliodal)
        {
            _portfoliodal = portfoliodal;
        }

        public void Tadd(portfolio t)
        {
            _portfoliodal.insert(t);
        }

        public void Tdelete(portfolio t)
        {
            _portfoliodal.delete(t);
        }

        public portfolio TGetByID(int id)
        {
            return _portfoliodal.GetByID(id);
        }

        public portfolio TGetByID(object id)
        {
            throw new NotImplementedException();
        }

        public List<portfolio> TGetList()
        {
            return _portfoliodal.Getlist();
        }

        public List<portfolio> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(portfolio t)
        {
            _portfoliodal.update(t);
        }
    }
}
