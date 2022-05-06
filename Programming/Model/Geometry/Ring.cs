﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Classes;

namespace Programming.Model.Geometry
{
    public class Ring
    {
        private double _outerRadius;

        private double _innerRadius;

        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue (value, nameof(OuterRadius));
                Validator.AssertValueInRange (nameof(OuterRadius), value, _innerRadius, double.MaxValue);
                _outerRadius = value;
            }
        }

        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue (value, nameof(InnerRadius));
                Validator.AssertValueInRange (nameof(InnerRadius), value, 0, _outerRadius);
                _innerRadius = value;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * (_outerRadius * _outerRadius - _innerRadius * _innerRadius);
            }
        }

        public Point2D Center { get; set; }

        public Ring (Point2D center,
                   double outerRadius,
                   double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;

        }
    }
}