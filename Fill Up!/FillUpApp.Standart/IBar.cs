using System;
using System.Collections.Generic;
using System.Text;

namespace FillUpApp.Standart
{
    public interface IBar
    {
        int Id { get; set; }
        string BarName { get; set; }
        int RatingOfBar { get; set; }
    }
}
