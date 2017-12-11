using Android.App;
using Android.OS;
using Android.Widget;
using Fill_Up_App.Code.Data;
using FillUpApp.Standart;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Fill_Up_App.Code.Activities
{
    [Activity(Label = "Fill Up!")]
    public class SkipActivity : Activity
    {
        private ListView list;
        private List<string> a;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SetLayout);

            if(Intent.GetIntExtra("metodas", -1) == 1)
            {
                DoSkip();
            }else if(Intent.GetIntExtra("metodas", -1) == 2)
            {
                DoTake();
            }else if(Intent.GetIntExtra("metodas", -1) == 3)
            {
                DoAggregate();
            }
            else if (Intent.GetIntExtra("metodas", -1) == 4)
            {
                DoGroup();
            }

            Button gobackbutton = FindViewById<Button>(Resource.Id.goBackBut);
            gobackbutton.Click += new EventHandler(this.gobackbutton_Click);
        }

        void gobackbutton_Click(Object sender, EventArgs e)
        {
            Finish();
        }

        async void DoSkip()
        {
            list = FindViewById<ListView>(Resource.Id.listView1);
            a = new List<string>();
            a.Add("Visi barai, išskyrus pirmąjį:");

            var db = DatabaseProcessing.Database();

            try
            {
                using (db)
                {
                    var barsInDatabase = await db.Bars.ToListAsync();
                    var barai = barsInDatabase.Skip(1);

                    foreach (var bar in barai)
                    {
                        a.Add($"{bar.BarName}       {bar.RatingOfBar} \u2605" + System.Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, a);
            list.Adapter = adapter;
        }

        async void DoTake()
        {
            list = FindViewById<ListView>(Resource.Id.listView1);
            a = new List<string>();
            a.Add("Pirmasis baras:");

            var db = DatabaseProcessing.Database();

            try
            {
                using (db)
                {
                    var barsInDatabase = await db.Bars.ToListAsync();
                    var barai = barsInDatabase.Take(1);

                    foreach (var bar in barai)
                    {
                        a.Add($"{bar.BarName}       {bar.RatingOfBar} \u2605" + System.Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, a);
            list.Adapter = adapter;
        }

        async void DoAggregate()
        {
            list = FindViewById<ListView>(Resource.Id.listView1);
            a = new List<string>();
            a.Add("Visų barų įvertinimų vidurkis:");

            var db = DatabaseProcessing.Database();

            try
            {
                using (db)
                {
                    var barsInDatabase = await db.Bars.ToListAsync();
                    List<int> ratings = new List<int>();
                    int count = 0;

                    foreach (var bar in barsInDatabase)
                    {
                        ratings.Add(bar.RatingOfBar);
                        count++;
                    }
                    int result = ratings.Aggregate((a, b) => b + a); //visa suma ivertinimu
                    double average = result / count; //vidurkis, ji isvedu
                    a.Add($"{average} \u2605" + System.Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, a);
            list.Adapter = adapter;
        }

        async void DoGroup()
        {
            list = FindViewById<ListView>(Resource.Id.listView1);
            a = new List<string>();
            a.Add("Barai įvertinti 5 \u2605:");

            var db = DatabaseProcessing.Database();

            try
            {
                using (db)
                {
                    var barsInDatabase = await db.Bars.ToListAsync();

                    var result = from bar in barsInDatabase
                                 orderby bar
                                 group bar by IsFiveStars(bar);

                    foreach (var group in result)
                    {
                        if (group.Key == true)
                        {
                            foreach (var value in group)
                            {
                                a.Add($"{value.BarName}       {value.RatingOfBar} \u2605" + System.Environment.NewLine);
                            }
                        }
                    }

                    bool IsFiveStars(Bar bar)
                    {
                        return bar.RatingOfBar == 5;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, a);
            list.Adapter = adapter;
            
        }
    }
}