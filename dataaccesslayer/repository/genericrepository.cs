using dataaccesslayer.asbtract;
using dataaccesslayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dataaccesslayer.repository
{
    public class genericrepository<T> : Igenericdal<T> where T : class
    {
        public void delete(T t)
        {
            using var c = new context();
            c.Remove(t);
            c.SaveChanges();
        }

        public List<T> GetbyFilter(Expression<Func<T, bool>> filter)
        {
            using var c = new context();
            return c.Set<T>().Where(filter).ToList();
        }

        public T GetByID(int id)
        {
            using var c=new context();
            return c.Set<T>().Find(id);
        }

        public List<T> Getlist()
        {
            using var c = new context();
            return c.Set<T>().ToList();
        }

        public void insert(T t)
        {
            using var c = new context();
            c.Add(t);
            c.SaveChanges();
        }

        public void update(T t)
        {
            using var c = new context();
            c.Update(t);
            c.SaveChanges();
        }
    }

}
