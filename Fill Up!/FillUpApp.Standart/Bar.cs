using System.ComponentModel.DataAnnotations;

namespace FillUpApp.Standart
{
    public class Bar
    {
        [Key]
        public string BarName { get; set; }
        public int RatingOfBar { get; set; }
    }
}
