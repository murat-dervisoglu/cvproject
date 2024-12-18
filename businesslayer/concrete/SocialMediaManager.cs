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
    public class SocialMediaManager:Isocialmediaservice
    {
        Isocialmediadal _socialMediaDal;

        public SocialMediaManager(Isocialmediadal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void Tadd(socialmedia t)
        {
            _socialMediaDal.insert(t);
        }

        public void Tdelete(socialmedia t)
        {
            _socialMediaDal.delete(t);
            
        }

        public socialmedia TGetByID(int id)
        {
            return _socialMediaDal.GetByID(id);
        }

        public List<socialmedia> TGetList()
        {
            return _socialMediaDal.Getlist();
        }

        public List<socialmedia> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(socialmedia t)
        {
            _socialMediaDal.update(t);
        }
    }
}
