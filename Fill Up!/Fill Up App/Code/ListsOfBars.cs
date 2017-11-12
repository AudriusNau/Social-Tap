using Android.OS;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Fill_Up_App.Code
{
    public class ListsOfBars : ISerializable
    {
        private List<VisitedBar> barList;
        private List<RatedBar> ratedBars;

        public ListsOfBars()
        {
            this.barList = new List<VisitedBar>();
        }

        public void AddNewBar(VisitedBar bar)
        {
            this.barList.Add(bar);
        }

        public List <VisitedBar> GetBarList()
        {
		    return barList;
	    }

        public List<RatedBar> GetRatings()
        {
            ratedBars = new List<RatedBar>();
            int rating;

            foreach (VisitedBar b in this.barList)
            {
                rating = GetAvarageRating(b.Name);
                ratedBars.Add(new RatedBar{Name = b.Name,  Rating = rating});
            }

            IEnumerable<RatedBar> distinctList = ratedBars.Distinct();

            var orderedList = from y in distinctList
                              orderby y.Rating descending, y.Name ascending
                              select y;
            /*
             * IEnumerable<RatedBar> x = ratedBars.Distinct();
             * List<RatedBar> distinctRatedBars = x.ToList();
             * distinctRatedBars.Sort();
             * distinctRatedBars.Reverse();
             * return distinctRatedBars();             * 
             */

            return orderedList.ToList();
        }

        public int GetAvarageRating(string name)
        {
            float sum = 0, count = 0;
            foreach(VisitedBar b in barList)
            {
                if (b.Name == name)
                {
                    sum += b.Rating;
                    count++;
                }
            }
            float rez = sum / count;
            int rezz = (int)rez;
            return rezz;
        }

        public IEnumerable <string> GetBetterBars(VisitedBar visitedBar)
        {
            var x = from bar in barList
                    where (bar.Glass.OrderedQuantity == visitedBar.Glass.OrderedQuantity) &&
                          (bar.Glass.LackOfBeer < visitedBar.Glass.LackOfBeer) &&
                          (bar.Glass.Price <= visitedBar.Glass.Price)
                    select bar.Name;
            return x.Distinct();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("barlist", barList, typeof(List<VisitedBar>));
            info.AddValue("ratedbars", ratedBars, typeof(List<RatedBar>));
        }
    }
}