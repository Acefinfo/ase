using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Shape
    {
        public virtual double Area()
        {
            return 0.0;
        }
        public virtual double Perimeter()
        {
            return 0.0;
        }
    }

}
