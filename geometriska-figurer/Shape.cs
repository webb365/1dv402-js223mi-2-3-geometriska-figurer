using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace geometriska_figurer
{
    public enum ShapeType
    {
        Rectangle,
        Ellipse,
    }
    public abstract class Shape : IComparable 
    {
        private double _length;
        private double _width;

      
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
                return Math.Round(_length, 1);
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Värdet är för litet");
                _length = value;
            }
        }
        public double Width
        {
            get
            {
                return Math.Round(_width, 1);
            }
            set
            {
                if (value < 0 )
                    throw new ArgumentException("Värdet är för litet");
                _width = value;
            }
        }


        public int CompareTo(Object obj)
        {
            
            if (obj == null)
                return 1;


            Shape other = obj as Shape;
            if (other == null)
                throw new ArgumentException("Shape är inte ett objekt");

           
            if (other.Area > this.Area)
                return -1;
            else if (other.Area < this.Area)
                return 2;
            else
                return 0;
        }

        public override string ToString()
        {
            StringBuilder geometricShape = new StringBuilder();

            geometricShape.AppendFormat("{0, -10}", GetType().Name);
            geometricShape.AppendFormat("{0, 8:f1}", Length);
            geometricShape.AppendFormat("{0, 11:f1}", Width);
            geometricShape.AppendFormat("{0, 12:f1}", Perimeter);
            geometricShape.AppendFormat("{0, 15:f1}", Area);

            return geometricShape.ToString();
        }

    }
}
