using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using SocialtapAPI;
using Newtonsoft.Json.Linq;

namespace FillUpWeb
{
    [Route("api/[controller]")]
    public class ValuesController : Controller, IValues
    {
        public static Dictionary<string, BarData> _barData = new Dictionary<string, BarData>();
        public static string _stats;

        public ValuesController()
        {

        }
        /// Metodui paduodami 2 parametrai, patikrinama ar jie atitinka reikalavimus, suvienodinami pavadinimai naudojant kitus metodus 
        /// į _barData Dictionary sudedamos reikšmės
        [HttpPost("AddBarReview/{barName}/{orderedQuantity}/{lackOfBeer}/{price}/{ratingOfBar}")]
        public Boolean AddBarReview(string barName, double orderedQuantity, int lackOfBeer, double price, int ratingOfBar)
        {
            Calculations calc = new Calculations();
            Console.WriteLine($"POST: AddBarReview/{barName}/{orderedQuantity}/{lackOfBeer}/{price}/{ratingOfBar}");

            ///Validation: patikrina ar paduoti tinkami kintamieji:
            /// Ar rate mažiau lygu 5 ir daugiau nei 0
            /// Ar baro vardas yra bent 1 simblos 
            if (!calc.Validation(ratingOfBar, barName))
            {
                return false;
            }
            barName = calc.BarNameAdaptation(barName);
            _barData = calc.AddBarInfo(barName, orderedQuantity, lackOfBeer, price, ratingOfBar);
            _stats = calc.Stats();
            return true;

        }
        /// Iškvietus šitą metodą, jis grąžina visą Dictionary į programą
        [HttpGet]
        [Route("GetBarData")]
        public IDictionary<string, BarData> GetBarData()
        {
            Console.WriteLine($"GET: GetBarData/");
            return _barData;

        }
        /// Iškvietus šitą metodą, sukuriama informacija apie geriausią barą ir bendrus skaičius
        [HttpGet]
        [Route("Stats")]
        public string GetStats()
        {
            Console.WriteLine($"GET: Stats/");

            return _stats;
        }

    }
}
