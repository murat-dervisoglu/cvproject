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
    public class TestimonialMenager : Itestimonialservice
    {
        Itestimonialdal _testimonialdal;

        public TestimonialMenager(Itestimonialdal testimonialdal)
        {
            _testimonialdal = testimonialdal;
        }

        public void Tadd(testimonial t)
        {
            _testimonialdal.insert(t);
        }

        public void Tdelete(testimonial t)
        {
            _testimonialdal.delete(t);
        }

        public testimonial TGetByID(int id)
        {
            return _testimonialdal.GetByID(id);
        }

        public List<testimonial> TGetList()
        {
            return _testimonialdal.Getlist();
        }

        public List<testimonial> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void Tupdate(testimonial t)
        {
            _testimonialdal.update(t);
        }
    }
}
