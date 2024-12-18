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
    public class SkillMenager:Iskillservice
    {
        Iskilldal _skilldal;

        public SkillMenager(Iskilldal skilldal)
        {
            _skilldal = skilldal;
        }

        public void Tadd(skill t)
        {
            _skilldal.insert(t);
        }

        public void Tdelete(skill t)
        {
            _skilldal.delete(t);
        }

        public skill TGetByID(int id)
        {
            return _skilldal.GetByID(id);
        }

        public List<skill> TGetList()
        {
            return _skilldal.Getlist();
        }

        public List<skill> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(skill t)
        {
            _skilldal.update(t);
        }
    }
}
