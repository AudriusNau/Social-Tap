using Android.App;
using Android.OS;

namespace Fill_Up_App
{
    [Activity(Label = "Fill_Up_App")]
    internal class Activity2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Layout1);

        }
    }
}