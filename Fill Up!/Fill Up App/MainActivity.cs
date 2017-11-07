using Android.App;
using Android.Widget;
using Android.OS;

namespace Fill_Up_App
{
    [Activity(Label = "Fill_Up_App", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);


            Button button1 = FindViewById<Button>(Resource.Id.button1);
            Button button2 = FindViewById<Button>(Resource.Id.button2);

            button1.Click += delegate {
                StartActivity(typeof(Activity2));
            };

            button2.Click += delegate {
                StartActivity(typeof(Activity3));
            };
        }
    }
}

