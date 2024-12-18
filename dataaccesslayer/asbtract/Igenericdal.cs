using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dataaccesslayer.asbtract
{
    public interface Igenericdal<T> where T : class
    {
        void insert(T t);
        void delete(T t);
        void update(T t);
        List<T> Getlist();
        T GetByID(int id);
        List<T> GetbyFilter(Expression<Func<T, bool>> filter);
    }
}
