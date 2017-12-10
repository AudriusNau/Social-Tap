using Android.App;
using Android.OS;
using Android.Widget;
using FillUpApp.Standart;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;

namespace Fill_Up_App.Code
{
    [Activity(Label = "Fill Up!")]
    public class Results: Activity
    {
        private ListView list;
        private List <string> a;

        private Lazy<Results> _lazyProperty = new Lazy<Results>(() => new Results());

        public Results MyProperty
        {
            get
            {
                return _lazyProperty.Value;
            }
        }

        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ResultsLayout);
            BarReview bar1 = new BarReview(Intent.GetStringExtra("name"), Intent.GetIntExtra("rating", -1));

            list = FindViewById<ListView>(Resource.Id.listView1);
            a = new List<string>();
            a.Add("Baras:" + " " + bar1.BarName);
            a.Add("Įvertinimas:" + " " + bar1.RatingOfBar.ToString());
            a.Add("");

            int rating = bar1.RatingOfBar;
            string betterBar = bar1.BarName;
            //FillUpWeb.FillUpWebService client = new FillUpWeb.FillUpWebService();
            //string betterBar = client.FindBetterBarName(bar.BarName, bar.RatingOfBar);

            var dbFullPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Bars.db");
            var db = new BarContext(dbFullPath);

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