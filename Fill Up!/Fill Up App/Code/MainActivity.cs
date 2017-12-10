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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            Thread th = new Thread(SoundTracks.SoundTrack);
            th.Start();

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            DeleteFromTable();

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

        public static async void DeleteFromTable()
        {
            var dbFullPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Bars.db");
            var db = new BarContext(dbFullPath);

            try
            {
                using (db)
                {
                    await db.Database.MigrateAsync(); //We need to ensure the latest Migration was added. This is different than EnsureDatabaseCreated.

                    db.Database.ExecuteSqlCommand("DELETE FROM [Bars]");
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
    }
}

