using Android.App;
using Android.Widget;
using Fill_Up_App.Code;
using Android.OS;

namespace Fill_Up_App
{
    [Activity(Label = "Fill Up!", MainLauncher = true, Icon = "@drawable/beerIcon")]
    public class MainActivity : Activity
    {
        ListsOfBars allbars;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Pagrindinio view'o inicializacija
            SetContentView(Resource.Layout.Main);

            allbars = new ListsOfBars();

            Button button1 = FindViewById<Button>(Resource.Id.evaluationButton);
            Button button2 = FindViewById<Button>(Resource.Id.ratingsButton);

            button1.Click += delegate {
                StartActivity(typeof(Evaluation));
            };

            button2.Click += delegate {
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

