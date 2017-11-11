using Android.App;
using Android.Widget;
using Fill_Up_App.Code;
using Android.OS;

namespace Fill_Up_App
{
    [Activity(Label = "Fill_Up_App", MainLauncher = true)]
    public class MainActivity : Activity
    {
        ListsOfBars allbars;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
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
    }
}

