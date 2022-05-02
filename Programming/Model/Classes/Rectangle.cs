using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private static int _allRectanglesCount;

        private double _height;

        private double _width;

        private int _id;

        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }

        public double Height
        {
            get 
            { 
                return _height; 
            }
            set
            {
                Validator.AssertOnPositiveValue (value, "Length");
                _height = value;
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
                Validator.AssertOnPositiveValue (value, "Width");
                _width = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public Point2D Center { get; set; }

        public string Color { get; set; }

        public Rectangle () 
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public Rectangle (double height, double width, string color, Point2D center)
        {
            Height = height;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }
    }
}
