using System.Collections.Generic;

namespace Fill_Up_
{
    public class AllBars
    {
        private List <Bar> barList;

        public AllBars()
        {
            barList = new List<Bar>();
        }

        public void addNewBar(Bar bar)
        {
            barList.Add(bar);
        }

        public List <Bar> getBarList()
        {
		    return this.barList;
	    }
    }
}