using System.ComponentModel.DataAnnotations;

namespace FillUpApp.Standart
{
    class GlassOfBeer
    {
        [Key]
        public double Size { get; set; }
        public double BeerAmount { get; set; }
        public double Proportion { get; set; }
    }
}
