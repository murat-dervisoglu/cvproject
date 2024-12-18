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
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            this._announcementDal = announcementDal;
        }

        public void Tadd(Announcement t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(Announcement t)
        {
            throw new NotImplementedException();
        }

        public Announcement TGetByID(int id)
        {
            return _announcementDal.GetByID(id);
        }

        public List<Announcement> TGetList()
        {
            return _announcementDal.Getlist();
        }

        public List<Announcement> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(Announcement t)
        {
            throw new NotImplementedException();
        }
    }
}
