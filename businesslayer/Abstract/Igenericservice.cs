using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businesslayer.Abstract
{
    public interface Igenericservice<T>
    {
    void Tadd(T t);
    void Tdelete(T t);
    void Tupdate(T t);
    List<T> TGetList();
    T TGetByID(int id);
    List<T> TGetListbyFilter();
    }
}
