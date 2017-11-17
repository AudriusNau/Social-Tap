using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FillUpWeb
{
    public class ICalculations
    {
        string BarNameAdaptation(string barName);
        double BarRateAverage(string barName, int ratingOfBar);
        Boolean Validation(int ratingOfBar,  string barName);
        Boolean IsBarNew(string barName);
        Dictionary<string, BarData> AddBarInfo(string barName, int ratingOfBar);
        string BestBarRate();
        string Stats();
    }
}
