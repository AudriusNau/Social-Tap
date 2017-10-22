using System;
using System.Collections.Generic;

namespace Fill_Up_
{
    public class RatedBar : IBar, IEquatable <RatedBar>, IComparable <RatedBar>
    {
        private string name;
        private int rating;

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

        public int CompareTo(RatedBar other)
        {
            return this.Rating.CompareTo(other.Rating);
        }

        public bool Equals(RatedBar other)
        {
            return Name.Equals(other.Name) && Rating.Equals(other.Rating);
        }

        public override int GetHashCode()
        {
            int hashProductName = Name == null ? 0 : Name.GetHashCode();
            int hashProductRating = Rating.GetHashCode();
            return hashProductName ^ hashProductRating;
        }
    }
}
