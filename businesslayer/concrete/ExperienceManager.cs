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
	public class ExperienceManager: IExperienceService
	{
		public readonly Iexperiencedal _experiencedal;

		public ExperienceManager(Iexperiencedal experiencedal)
		{
			_experiencedal = experiencedal;
		}

		public void Tadd(experience t)
		{
			_experiencedal.insert(t);
		}

		public void Tdelete(experience t)
		{
			_experiencedal.delete(t);
		}

		public experience TGetByID(int id)
		{
			return _experiencedal.GetByID(id);
		}

		public List<experience> TGetList()
		{
			return _experiencedal.Getlist();
		}

        public List<experience> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(experience t)
		{
			 _experiencedal.update(t);
		}
	}
}
