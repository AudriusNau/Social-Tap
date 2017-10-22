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
            //Get hash code for the Name field if it is not null. 
            int hashProductName = Name == null ? 0 : Name.GetHashCode();

            //Get hash code for the Code field. 
            int hashProductRating = Rating.GetHashCode();

            //Calculate the hash code for the product. 
            return hashProductName ^ hashProductRating;
        }
    }
}
