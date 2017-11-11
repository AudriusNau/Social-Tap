using System.Runtime.Serialization;

namespace Fill_Up_App.Code
{
    public class VisitedBar :IBar
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public GlassOfBeer Glass { get; set; }

        public VisitedBar()
        {
            Name = null;
            Rating = 0;
            Glass = new GlassOfBeer();
        }

        public VisitedBar(string name, int rating, GlassOfBeer glass)
        {
            this.Name = name;
            this.Rating = rating;
            Glass = glass;
        }
    }
}