using System.Collections.Generic;
using System;

namespace Fill_Up_App.Code
{
    public class VisitedBar //: IBar
    {
        public string Name { get; set; }
        public float Rating { get; set; }
        public GlassOfBeer Glass { get; set; }

        public VisitedBar()
        {
            Name = null;
            Rating = 0;
            Glass = new GlassOfBeer();
        }

        public VisitedBar(string name, float rating, GlassOfBeer glass)
        {
            this.Name = name;
            this.Rating = rating;
            Glass = glass;
        }
    }
}