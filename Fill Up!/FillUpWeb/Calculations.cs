using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FillUpWeb
{
    public class Calculations : ICalculations
    {
        private static Dictionary<string, List<int>> _barRates = new Dictionary<string, List<int>>();
        public double _max;
        public static string _bestbar;
        public const int MAX_RATING = 5; // kiek daugiausiai gali duoti žvaigždučių 
        public const int MIN_NAME_LENGHT = 1; //trumpiausias įmanomas baro pavadinimas
        public const int MIN_RATING = 0; //kiek mažiausiai gali duoti žvaigždučių 

        public static Dictionary<string, BarData> _barData = new Dictionary<string, BarData>();

        public Calculations()
        {

        }

        public string BarNameAdaptation(string barName)
        {
            barName = barName.ToLower();
            barName = barName.Replace(" ", string.Empty).Replace("-", string.Empty).Replace(".", string.Empty);  // pasalina visus tarpus, taškus ir -
            barName = char.ToUpper(barName[0]) + barName.Substring(1);

            return barName;
        }
        /// Į metodą paduodamas baro pavadinimas ir jo įvertinimas, web service laikome baro pavadinimą ir jo įvertinimų Listą 
        /// Atgal grąžiname tik baro įvertinimų vidurkį
        /// http://localhost:.../api/values/barrate/string_baropavadinimas/string_įvertinimas
        public double BarRateAverage(string barName, int ratingOfBar)
        {

            if (_barRates.Keys.Contains(barName))
            {
                _barRates[barName].Add(ratingOfBar);
            }
            else
            {
                _barRates[barName] = new List<int> { ratingOfBar };
            }
            return _barRates[barName].Average();
        }

        /// Patikrina ar paduoti tinkami kintamieji:
        /// Ar rate mažiau lygu 5 ir daugiau nei 0
        /// Ar baro vardas yra bent 1 simblos 
        public Boolean Validation(int ratingOfBar, string barName)
        {
            return !(ratingOfBar > MAX_RATING || barName.Length < MIN_NAME_LENGHT
                  || ratingOfBar < MIN_RATING);
        }

        /// Baro pavadinimui priskiria reikiamas reiksmes
        /// Grąžina Dictionary
        public Dictionary<string, BarData> AddBarInfo(string barName, int ratingOfBar)
        {
            IsBarNew(barName);
            _barData[barName].RateAvg = BarRateAverage(barName, ratingOfBar);

            return _barData;
        }

        /// Patikrina ar naujas baras
        /// Jeigu naujas, sukuria naują elementą Dictionary
        public Boolean IsBarNew(string barName)
        {
            if (!_barData.Keys.Contains(barName))
            {
                _barData.Add(barName, new BarData());
                return false;
            }
            return true;
        }

        // Geriausias baras pagal ivertinimus
        public string BestBarRate()
        {
            foreach (string barName in _barData.Keys)
            {

                if (_barData[barName].RateAvg > _max)
                {
                    _max = _barData[barName].RateAvg;
                    _bestbar = barName;
                }
            }
            return _bestbar;
        }

        public string Stats()
        {
            string bestBar = BestBarRate();
            /* string statsInfo = "Baro pavadinimas " + bestBar + " Jo žvaigždučių vidurkis" + _barData[bestBar].RateAvg; */
            dynamic stats = new JObject();
            stats.BarName = bestBar;
            stats.RateAvg = _barData[bestBar].RateAvg;

            return stats.ToString();
        }
    }
}
