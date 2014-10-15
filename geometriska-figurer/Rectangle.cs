﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace geometriska_figurer
{
    public class Rectangle : Shape
    {
        public override double Area
        {
            get
            {
                return Width * Length;
            }
        }

        public override double Perimeter
        {
            get
            {
                return (2 * Length) + (2 * Width);
            }
        }

        public Rectangle(double length, double width)
            : base(length, width)
        {

        }
    }
}
