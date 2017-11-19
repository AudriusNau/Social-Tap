namespace FillUpWeb
{
    public class BarData : IBarData
    {
        public double RateAvg { get; set; }  //žvaigždučių vidurkis
        public bool Comparison { get; set; } //ar geriau įpylė visų barų palyginime
    }
}
