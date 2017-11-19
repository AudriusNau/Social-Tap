using Android.App;
using Android.OS;
using Android.Widget;
using System;
using System.Text.RegularExpressions;
using Android.Content;
using FillUpWeb;

namespace Fill_Up_App
{
    [Activity(Label = "Fill Up!")]
    public class Evaluation : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.EvaluationLayout);

            Button savebutton = FindViewById<Button>(Resource.Id.saveButton);
            savebutton.Click += new EventHandler(this.savebutton_Click);

            Button gobackbutton = FindViewById<Button>(Resource.Id.goBackButton);
            gobackbutton.Click += new EventHandler(this.gobackbutton_Click);
        }

        void savebutton_Click(Object sender, EventArgs e)
        {
            if (((EditText)FindViewById(Resource.Id.barName)).Text == string.Empty)
            {
                Toast.MakeText(Application.Context, "Įveskite baro pavadinimą", ToastLength.Long).Show();
                return;
            }

            if (!Regex.IsMatch(((EditText)FindViewById(Resource.Id.barName)).Text, @"^[a-zA-Z0-9 ]*$"))
            {
                Toast.MakeText(Application.Context, "Pavadinime gali būti tik raidės, skaičiai ir tarpai!", ToastLength.Long).Show();
                return;
            }

            Intent intent = new Intent(this, typeof(Results));
            Bundle bundle = new Bundle();
            bundle.PutString("name", ((EditText)FindViewById(Resource.Id.barName)).Text);
            bundle.PutInt("rating", (int)((RatingBar)FindViewById(Resource.Id.ratingOfBar)).Rating);
            intent.PutExtras(bundle);
            StartActivity(intent);

            ValuesController vs = new ValuesController();
            bool value = vs.AddBarReview(((EditText)FindViewById(Resource.Id.barName)).Text, (int)((RatingBar)FindViewById(Resource.Id.ratingOfBar)).Rating);

        }

        void gobackbutton_Click(Object sender, EventArgs e)
        {
            Finish();
        }
    }
}