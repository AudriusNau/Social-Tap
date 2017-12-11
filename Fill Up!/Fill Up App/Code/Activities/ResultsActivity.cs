using Android.App;
using Android.OS;
using Android.Widget;
using FillUpApp.Standart;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using Fill_Up_App.Code.Data;

namespace Fill_Up_App.Code.Activities
{
    [Activity(Label = "Fill Up!")]
    public class ResultsActivity: Activity
    {
        private ListView list;
        private List <string> a;

        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ResultsLayout);

            BarReview bar1 = new BarReview(Intent.GetStringExtra("name"), Intent.GetIntExtra("rating", -1));
            double orderedMug = Intent.GetDoubleExtra("mug", -1);
            double percent = Intent.GetIntExtra("result", -1);
            double result = orderedMug * percent / 100;

            list = FindViewById<ListView>(Resource.Id.listView1);
            a = new List<string>();
            a.Add("Baras: " + bar1.BarName);
            a.Add("Užsakytas bokalas: " + orderedMug);
            a.Add("Įvertinimas: " + bar1.RatingOfBar.ToString());
            a.Add("Rezultatas: " + result + " l");
            a.Add("");

            int rating = bar1.RatingOfBar;
            string betterBar = bar1.BarName;
            FillUpWeb.FillUpWebService client = new FillUpWeb.FillUpWebService();

            var db = DatabaseProcessing.Database();

            try
            {
                using (db)
                {
                    var barsInDatabase = await db.Bars.ToListAsync();

                    foreach (var bar in barsInDatabase)
                    {
                        if (bar.RatingOfBar >= rating)
                        {
                            betterBar = bar.BarName;
                            break;
                        }
                    }
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            if (betterBar != null && betterBar != bar1.BarName)
            {
                a.Add("Siūlome jums apsilankyti:" + betterBar);
            }
            else if(betterBar == bar1.BarName)
            {
                a.Add("Jūsų baras puikus!");
            }

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, a);
            list.Adapter = adapter;

            Button gobackbutton = FindViewById<Button>(Resource.Id.goBackBut);
            gobackbutton.Click += new EventHandler(this.gobackbutton_Click);
        }

        void gobackbutton_Click(Object sender, EventArgs e)
        {
            Finish();
        }
    }
}