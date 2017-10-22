using System.Collections.Generic;
using System;

namespace Fill_Up_
{
    public class VisitedBar : IBar
    {
        private string name;
        private int rating;
        public GlassOfBeer Glass { get; set; }

        public VisitedBar()
        {
            Name = null;
            Rating = 0;
            Glass = new GlassOfBeer();
        }

        public VisitedBar(string name, int rating, GlassOfBeer glass)
        {
            this.Name = name;
            this.Rating = rating;
            Glass = glass;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
    }
}