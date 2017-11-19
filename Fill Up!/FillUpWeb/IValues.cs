using System;
using System.Collections.Generic;
using System.Linq;

namespace FillUpWeb
{
    public interface IValues
    {
        Boolean AddBarReview(string barName, int ratingOfBar);
        IDictionary<string, BarData> GetBarData();
        IOrderedEnumerable<KeyValuePair<string, BarData>> GetSortedBarData();
        string GetStats();
    }
}
