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
	public class ToDoListManager : IToDoListService
	{
		IToDoListDal _toDoListDal;

		public ToDoListManager(IToDoListDal toDoListDal)
		{
			_toDoListDal = toDoListDal;
		}

		public void Tadd(ToDoList t)
		{
			throw new NotImplementedException();
		}

		public void Tdelete(ToDoList t)
		{
			throw new NotImplementedException();
		}

		public ToDoList TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<ToDoList> TGetList()
		{
			return _toDoListDal.Getlist();
		}

        public List<ToDoList> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(ToDoList t)
		{
			throw new NotImplementedException();
		}
	}
}
