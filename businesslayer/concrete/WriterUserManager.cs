﻿using businesslayer.Abstract;
using dataaccesslayer.asbtract;
using entitylayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businesslayer.concrete
{
    public class WriterUserManager : IWriterUserService
    {
        IWriterUserDal _writerUserDal;

        public WriterUserManager(IWriterUserDal writerUserDal)
        {
            _writerUserDal = writerUserDal;
        }

        public void Tadd(WriterUser t)
        {
            throw new NotImplementedException();
        }

        public void Tdelete(WriterUser t)
        {
            throw new NotImplementedException();
        }

        public WriterUser TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<WriterUser> TGetList()
        {
            return _writerUserDal.Getlist();
        }

        public List<WriterUser> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(WriterUser t)
        {
            throw new NotImplementedException();
        }
    }
}
