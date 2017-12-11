using System.Collections.Generic;

namespace Fill_Up_App.Code.Data
{
    public interface IBarData
    {
        double RateAvg { get; }
        bool Comparison { get; }
    }
}