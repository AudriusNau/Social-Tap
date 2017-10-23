using System.Collections.Generic;
using System.Linq;

namespace Fill_Up_
{
    public class ListsOfBars
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
            int sum = 0, count = 0;
            foreach(VisitedBar b in barList)
            {
                if (b.Name == name)
                {
                    sum += b.Rating;
                    count++;
                }
            }

            return sum / count;
        }

        public IEnumerable <string> GetBetterBars(VisitedBar visitedBar)
        {
            var x = from bar in barList
                    where (bar.Glass.OrderedQuantity == visitedBar.Glass.OrderedQuantity) &&
                          (bar.Glass.LackOfBeer < visitedBar.Glass.LackOfBeer) &&
                          (bar.Glass.Price < visitedBar.Glass.Price)
                    select bar.Name;
            return x.Distinct();
        }

        public VisitedBar FindBetterBar(VisitedBar bar)
        {
            VisitedBar betterBar = bar;

            foreach (VisitedBar iterator in barList)
            {
                if (iterator.Glass.OrderedQuantity == betterBar.Glass.OrderedQuantity 
                    && iterator.Glass.LackOfBeer < betterBar.Glass.LackOfBeer)
                    betterBar = iterator; 
            }
            return betterBar;
        }

        public VisitedBar FindCheaperBar(VisitedBar bar)
        {
            VisitedBar cheaperBar = bar;

            foreach (VisitedBar iterator in barList)
            {
                if (iterator.Glass.OrderedQuantity == cheaperBar.Glass.OrderedQuantity 
                    && iterator.Glass.Price < cheaperBar.Glass.Price)
                    cheaperBar = iterator;
            }
            return cheaperBar;
        }
    }
}