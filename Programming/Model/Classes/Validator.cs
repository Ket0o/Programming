using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if(value < 0)
            {
                throw new ArgumentException($"{propertyName} should not be negative");
            }
        } 
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if(value < 0)
            {
                throw new ArgumentException($"{propertyName} should not be negative");
            }
        }
    }
}
