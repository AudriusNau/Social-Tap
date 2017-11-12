using Android.App;
using Android.OS;
using Fill_Up_App.Code;
using Android.Widget;
using System;
using System.Text.RegularExpressions;

namespace Fill_Up_App
{
    [Activity(Label = "Fill_Up_App")]
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
            
            GlassOfBeer glass = new GlassOfBeer();
            glass.OrderedQuantity = Double.Parse(((EditText)FindViewById(Resource.Id.orderedQuantity)).Text);
            glass.LackOfBeer = int.Parse(((EditText)FindViewById(Resource.Id.lackOfBeer)).Text);
            glass.Price = Double.Parse(((EditText)FindViewById(Resource.Id.price)).Text);

            VisitedBar bar = new VisitedBar(((EditText)FindViewById(Resource.Id.barName)).Text, ((RatingBar)FindViewById(Resource.Id.ratingOfBar)).Rating, glass);

            /* 
             * allBars.AddNewBar(bar);
            */

            StartActivity(typeof(Results));
        }

        void gobackbutton_Click(Object sender, EventArgs e)
        {
            Finish();
        }
    };
}