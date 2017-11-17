using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FillUpWeb
{
    public class IValues
    {
        Boolean AddBarReview(string barName, double orderedQuantity, int lackOfBeer, double price, int ratingOfBar);
        IDictionary<string, BarData> GetBarData();
        string GetStats();
    }
}
