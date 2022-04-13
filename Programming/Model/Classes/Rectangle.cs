using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _length;

        private double _width;

        public double Length
        {
            get 
            { 
                return _length; 
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Length");
                _length = value;
            }
        }

        public double Width
        {
            get 
            { 
                return _width; 
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Width");
                _width = value;
            }
        }

        public Point2D Center { get; set; }

        public string Color { get; set; }

        public Rectangle() { }

        public Rectangle(double length, double width, string color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
        }
    }
}
