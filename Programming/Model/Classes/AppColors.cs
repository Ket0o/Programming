using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Programming.Model.Classes
{
    public static class AppColors
    {
        public static Color CorrectColor = Color.White;
        
        public static Color ErrorColor = Color.LightPink;
        
        public static Color IsCollisionTrue = Color.FromArgb(127, 255, 127, 127); 

        public static Color IsCollisionFalse = Color.FromArgb(127, 127, 255, 127); 
    }
}
