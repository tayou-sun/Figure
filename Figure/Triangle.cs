using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Triangle : IFigure
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public double GetArea()
        {
            var p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public bool IsRight()
        {
            return Math.Pow(_a, 2) == (Math.Pow(_b, 2) + Math.Pow(_c, 2)) ||
                   Math.Pow(_b, 2) == (Math.Pow(_a, 2) + Math.Pow(_c, 2)) ||
                   Math.Pow(_c, 2) == (Math.Pow(_a, 2) + Math.Pow(_b, 2));
        }
    }
}
