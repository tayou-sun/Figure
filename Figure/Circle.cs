using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Circle : IFigure
    {
        private readonly double _r;

        public Circle(float r)
        {
            _r = r;
        }

        public double GetArea()
        {
            return 3.14*Math.Pow(_r, 2);
        }
    }
}
