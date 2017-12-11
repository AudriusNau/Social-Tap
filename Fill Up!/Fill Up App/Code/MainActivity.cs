using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Threading;
using System.IO;
using FillUpApp.Standart;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Fill_Up_App.Code.Data;

namespace Fill_Up_App.Code.Activities
{
    [Activity(Label = "Fill Up!", MainLauncher = true, Icon = "@drawable/beerIcon")]
    public class MainActivity : Android.App.Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            DatabaseProcessing.DeleteFromTable();

            Button button1 = FindViewById<Button>(Resource.Id.evaluationButton);
            Button button2 = FindViewById<Button>(Resource.Id.ratingsButton);

           
            button1.Click += (object sender, EventArgs e) =>
            {
                StartActivity(typeof(TakePictureActivity));
            };

            button2.Click += (object sender, EventArgs e) =>
            {
                StartActivity(typeof(RatingsActivity));
            };
        }

        public static void ReportAddBarReviewState(bool status)
        {
            var reportContent = status ? "Išsaugota." : "Išsaugoti nepavyko.";
            Toast.MakeText(Application.Context, reportContent, ToastLength.Short).Show();
        }

    }
}

