using System.Collections.Generic;

namespace Fill_Up_
{
    public class AllBars
    {
        private List <Bar> barList = new List<Bar>();

        public void AddNewBar(Bar bar)
        {
            this.barList.Add(bar);
        }

        public List <Bar> GetBarList()
        {
		    return barList;
	    }

        public Bar FindBetterBar(Bar bar)
        {
            Bar betterBar = bar;

            foreach (Bar iterator in barList)
            {
                if (iterator.Glass.lackOfBeer < betterBar.Glass.lackOfBeer)
                    betterBar.Equals(iterator); 
            }
            return betterBar;
        }

        public Bar FindCheaperBar(Bar bar)
        {
            Bar cheaperBar = bar;

            foreach (Bar iterator in barList)
            {
                if (iterator.Glass.price < cheaperBar.Glass.price)
                    cheaperBar.Equals(iterator);
            }
            return cheaperBar;
        }
    }
}