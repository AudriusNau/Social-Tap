using Android.App;
using Android.OS;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.IO;
using FillUpApp.Standart;
using Microsoft.EntityFrameworkCore;

namespace Fill_Up_App.Code
{
    [Activity(Label = "Fill Up!")]
    internal class Ratings : Activity
    {
        private ListView list;
        private List<string> list1;

        protected override async void OnCreate(Bundle savedInstanceState)
        {
            FillUpWeb.FillUpWebService client = new FillUpWeb.FillUpWebService();
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RatingsLayout);

            list = FindViewById<ListView>(Resource.Id.listView2);
            list1 = new List<string>();

            list1.Add("Baras        Įvertinimas:");
            //var ratings = client.GetSortedBarData();
            //foreach(KeyValuePair < string, BarData> a in ratings)
            //{
            //    list1.Add(a.Key + " - " + a.Value.RateAvg.ToString());
            //}
            //-------------------------------------------------------------------------------------
            var dbFullPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Bars.db");
            var db = new BarContext(dbFullPath);

            try
            {
                using (db)
                {
                    // Entity
                    var barsInDatabase = await db.Bars.ToListAsync();

                    foreach (var bar in barsInDatabase)
                    {
                        list1.Add($"{bar.BarName}       {bar.RatingOfBar} \u2605" + System.Environment.NewLine);
                    }
                    await db.SaveChangesAsync();
                    // SELECT
                    //var barList = db.Bars.SqlQuery("SELECT BarName FROM Bars").ToList<Bar>();
                    //await db.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, list1);
            list.Adapter = adapter;
            //----------------------------------------------------------------------------------------
            Button gobackbutton = FindViewById<Button>(Resource.Id.goBackButton1);
            gobackbutton.Click += new EventHandler(this.gobackbutton_Click);
        }
        
        void gobackbutton_Click(Object sender, EventArgs e)
        {
            Finish();
        }
    }
}