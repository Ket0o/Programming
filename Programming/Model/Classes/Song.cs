using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        private string Name { get; set; }
        private string Executor { get; set; }
        private double _duration; // Число после запятой может быть от 00 до 59 

        public Song() { }

        public Song(string name, string executor, double duration)
        {
            Name = name;
            Executor = executor;
            Duration = duration;
        }

        public double Duration
        {
            get { return _duration; }
            set
            {
                if((value / 100) > 59 )
                {
                    throw new ArgumentException("В минуте 60 секунд");
                }
                else
                {
                    _duration = value;
                }
            }
        }
    }
}
