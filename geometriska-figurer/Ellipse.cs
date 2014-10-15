using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace geometriska_figurer
{
    public class Ellipse : Shape
    {
        public override double Area
        {
            get
            {
                return ((Length / 2) * (Width / 2)) * Math.PI;
            }
        }
        public override double Perimeter
        {
            get
            {
                double a = Length / 2;
                double b = Width / 2;
                return Math.PI * Math.Sqrt(2 * a * a + 2 * b * b);
            }
        }
        public Ellipse(double length, double width)
            : base(length, width)
        {

        }
    }
}
