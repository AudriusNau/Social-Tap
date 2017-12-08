using System;
using System.Collections.Generic;
using System.Text;

namespace FillUpApp.Standart
{
    public class Bar : IBar
    {
        public int Id { get; set; }
        public string BarName { get; set; }
        public int RatingOfBar { get; set; }

        public override string ToString()
        {
            return $"({Id}) {BarName}, {RatingOfBar}"; //return $"{BarName}, {RatingOfBar}";
        }
    }
}
