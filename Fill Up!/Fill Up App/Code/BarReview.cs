using System.Runtime.Serialization;

namespace Fill_Up_App.Code
{
    public class BarReview : IBarReview
    {
        public string BarName { get; }
        public int RatingOfBar { get; }

        public BarReview(string barName, int ratingOfBar)
        {
            BarName = barName;
            RatingOfBar = ratingOfBar;
        }
    }
}