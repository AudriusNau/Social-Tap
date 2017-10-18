using System.Collections.Generic;
using System;

namespace Fill_Up_
{
    public class Bar : IComparable <Bar>
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public GlassOfBeer Glass { get; set; }

        public Bar()
        {
            Name = null;
            Rating = 0;
            Glass = new GlassOfBeer();
        }

        public Bar(string name, int rating, GlassOfBeer glass)
        {
            Name = name;
            Rating = rating;
            Glass = glass;
        }

        public int CompareTo(Bar other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}