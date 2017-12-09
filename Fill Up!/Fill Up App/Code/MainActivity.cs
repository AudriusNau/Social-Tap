using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Threading;
using System.IO;
using FillUpApp.Standart;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Fill_Up_App.Code
{
    [Activity(Label = "Fill Up!", MainLauncher = true, Icon = "@drawable/beerIcon")]
    public class MainActivity : Android.App.Activity
    {
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            Thread th = new Thread(SoundTracks.SoundTrack);
            th.Start();

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            //TextView textView = FindViewById<TextView>(Resource.Id.TextView1);

            var dbFullPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Bars.db");
            var db = new BarContext(dbFullPath);

            try
            {
                using (db)
                {
                    await db.Database.MigrateAsync(); //We need to ensure the latest Migration was added. This is different than EnsureDatabaseCreated.

                    Bar barSnekutis = new Bar() { Id = 1, BarName = "Snekutis", RatingOfBar = 5 };
                    Bar barSkybar = new Bar() { Id = 2, BarName = "Skybar", RatingOfBar = 2 };
                    Bar barBaras = new Bar() { Id = 3, BarName = "Baras", RatingOfBar = 3 };

                    List<Bar> barsInList = new List<Bar>() { barSnekutis, barSkybar, barBaras };

                    if (await db.Bars.CountAsync() < 3)
                    {
                        await db.Bars.AddRangeAsync(barsInList);
                        await db.SaveChangesAsync();
                    }
                    //var barsInDatabase = await db.Bars.ToListAsync();

                    //foreach (var bar in barsInDatabase)
                    //{
                    //    textView.Text += $"{bar.BarName} - {bar.RatingOfBar}" + System.Environment.NewLine;
                    //}
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            Button button1 = FindViewById<Button>(Resource.Id.evaluationButton);
            Button button2 = FindViewById<Button>(Resource.Id.ratingsButton);

            // Lambda israiskos
            button1.Click += (object sender, EventArgs e) =>
            {
                StartActivity(typeof(TakePicture));
            };

            button2.Click += (object sender, EventArgs e) =>
            {
                StartActivity(typeof(Ratings));
            };
        }

        public static void ReportAddBarReviewState(bool status)
        {
            var reportContent = status ? "Išsaugota." : "Išsaugoti nepavyko.";
            Toast.MakeText(Application.Context, reportContent, ToastLength.Short).Show();
        }
    }
}

