using System;

namespace Fill_Up_App.Code
{
    public class RatedBar : IBar, IEquatable <RatedBar>, IComparable <RatedBar>
    {
        public string Name { get; set; }
        public int Rating { get; set; }

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
