using System.Runtime.Serialization;

namespace Fill_Up_App.Code
{
    public class BarReview : IBarReview
    {
        public int Id { get; set; }
        public string BarName { get; set; }
        public int RatingOfBar { get; set; }

        public override string ToString()
        {
            return $"({Id}) {BarName}, {RatingOfBar}";
        }

        public BarReview(string barName, int ratingOfBar)
        {
            BarName = barName;
            RatingOfBar = ratingOfBar;
        }
    }
}