using Android.App;
using Android.OS;
using Android.Widget;
using System;
using System.Text.RegularExpressions;
using Android.Content;
using Fill_Up_App.Code.Exceptions;

namespace Fill_Up_App.Code 
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
            try
            {
                if (((EditText)FindViewById(Resource.Id.barName)).Text == string.Empty)
                {
                    throw new BarNameEmptyException("Įveskite baro pavadinimą");
                }

                if (!Regex.IsMatch(((EditText)FindViewById(Resource.Id.barName)).Text, @"^[a-zA-Z0-9 ]*$"))
                {
                    throw new RegexException("Pavadinime gali būti tik raidės, skaičiai ir tarpai!");
                }

                Intent intent = new Intent(this, typeof(Results));
                Bundle bundle = new Bundle();
                bundle.PutString("name", ((EditText)FindViewById(Resource.Id.barName)).Text);
                bundle.PutInt("rating", (int)((RatingBar)FindViewById(Resource.Id.ratingOfBar)).Rating);
                intent.PutExtras(bundle);
                StartActivity(intent);

                FillUpWeb.FillUpWebService client = new FillUpWeb.FillUpWebService();
                bool value = client.AddBarReview(((EditText)FindViewById(Resource.Id.barName)).Text, (int)((RatingBar)FindViewById(Resource.Id.ratingOfBar)).Rating);
            }
            catch (BarNameEmptyException ex)
            {
                return;
            }
            catch (RegexException ex)
            {
                return;
            }
            catch (Exception ex)
            {
                Toast.MakeText(Application.Context, "Įvyko klaida!", ToastLength.Long).Show();
                return;
            }
        }

        void gobackbutton_Click(Object sender, EventArgs e)
        {
            Finish();
        }
    }
}