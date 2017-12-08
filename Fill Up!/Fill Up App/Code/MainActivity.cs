using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Threading;
using System.IO;
using FillUpApp.Standart;

namespace Fill_Up_App.Code
{
    [Activity(Label = "Fill Up!", MainLauncher = true, Icon = "@drawable/beerIcon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            var dbPath = Path.Combine(System.Environment.GetFolderPath
                (System.Environment.SpecialFolder.Personal), "barsDB.db");

            var barsRepository = new BarsRepository(dbPath); //duombaze
//--------------------------------------------------------------------------------------
            Thread th = new Thread(SoundTracks.SoundTrack);
            th.Start();

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            Button button1 = FindViewById<Button>(Resource.Id.evaluationButton);
            Button button2 = FindViewById<Button>(Resource.Id.ratingsButton);

            // Lambda israiskos
            button1.Click += (object sender, EventArgs e) => {
                StartActivity(typeof(TakePicture));
            };

            button2.Click += (object sender, EventArgs e) => {
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

