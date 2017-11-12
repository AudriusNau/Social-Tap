using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace FillUpWeb
{
    public class BarDataController : ApiController
    {
        BarData[] bars = new BarData[]
        {
            new BarData { Name = "Snekutis", Rating = 5 },
            new BarData { Name = "Skybar", Rating = 4 }
        };

        public IEnumerable<BarData> GetAllBars()
        {
            return bars;
        }

        public BarData GetBarByRating(int rating)
        {
            var bar = bars.FirstOrDefault((p) => p.Rating == rating);
            if (bar == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return bar;
        }

    }
}
