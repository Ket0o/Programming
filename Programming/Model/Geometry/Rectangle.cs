using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольниках.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Количйество всех прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;
        /// <summary>
        /// Высота.
        /// </summary>
        private int _height;
        /// <summary>
        /// Ширина.
        /// </summary>
        private int _width;
        /// <summary>
        /// Уникальный идентификатор для всех объектов класса.
        /// </summary>
        private int _id;
        /// <summary>
        /// 
        /// </summary>
        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }

        public int Height
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

        public int Width
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

        public Rectangle (int height, int width, string color, Point2D center)
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
