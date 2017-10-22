using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fill_Up_
{
    public class RatedBar : IBar, IComparable <RatedBar>
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
    }
}
