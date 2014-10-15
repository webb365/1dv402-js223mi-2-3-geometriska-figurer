using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace geometriska_figurer
{
    public abstract class Shape : IComparable 
    {
        private double _length;
        private double _width;

        protected Shape()
            : this(0, 0)
        {

        }
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }


        public abstract double Area { get; }
        public abstract double Perimeter { get; }


        public double Length
        {
            get
            {
               
            }
            set
            {
            
            }
        }
        public double Width
        {
            get
            {
                
            }
            set
            {
               
            }
        }


        public int CompareTo(Object obj)
        {

        }

        public override string ToString()
        {

        }

    }
}
