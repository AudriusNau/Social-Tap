using Android.App;
using Android.OS;
using Android.Widget;
using System;
using System.Text.RegularExpressions;
using Fill_Up_.Code;
using Android.Content;

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

            if (((EditText)FindViewById(Resource.Id.orderedQuantity)).Text == string.Empty)
            {
                Toast.MakeText(Application.Context, "Įveskite užsakytą kiekį!", ToastLength.Long).Show();
                return;
            }

            if (((EditText)FindViewById(Resource.Id.lackOfBeer)).Text == string.Empty)
            {
                Toast.MakeText(Application.Context, "Įveskite kiek neįpylė!", ToastLength.Long).Show();
                return;
            }

            if (((EditText)FindViewById(Resource.Id.price)).Text == string.Empty)
            {
                Toast.MakeText(Application.Context, "Įveskite kainą!", ToastLength.Long).Show();
                return;
            }
          
            Intent intent = new Intent(this, typeof(Results));
            Bundle bundle = new Bundle();
            bundle.PutString("name", ((EditText)FindViewById(Resource.Id.barName)).Text);
            bundle.PutDouble("mug", (((EditText)FindViewById(Resource.Id.orderedQuantity)).Text).StringToDouble());
            bundle.PutInt("lack", (((EditText)FindViewById(Resource.Id.lackOfBeer)).Text).StringToInt());
            bundle.PutDouble("price", (((EditText)FindViewById(Resource.Id.price)).Text).StringToDouble());
            bundle.PutInt("rating", (int)((RatingBar)FindViewById(Resource.Id.ratingOfBar)).Rating);
            intent.PutExtras(bundle);
            StartActivity(intent);
        }

        void gobackbutton_Click(Object sender, EventArgs e)
        {
            Finish();
        }
    };
}