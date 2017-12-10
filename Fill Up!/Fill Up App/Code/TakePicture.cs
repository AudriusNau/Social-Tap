using System;
using Android.App;
using Android.OS;
using Android.Widget;
using Android.Content;
using Android.Provider;
using Android.Runtime;
using Android.Graphics;
using Fill_Up_App.Code.Exceptions;
using System.Text.RegularExpressions;
using FillUpApp.Standart;
using System.Collections.Generic;
using System.Diagnostics;

namespace Fill_Up_App.Code
{
    [Activity(Label = "Fill Up!")]
    public class TakePicture : Android.App.Activity
    {
        ImageView imageView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.TakePictureLayout);

            Button savebutton = FindViewById<Button>(Resource.Id.savebutton);
            savebutton.Click += new EventHandler(this.savebutton_ClickAsync);

            Button gobackbutton = FindViewById<Button>(Resource.Id.goBackButton);
            gobackbutton.Click += new EventHandler(this.gobackbutton_Click);

            Button buttonCam = FindViewById<Button>(Resource.Id.takePictureButton);
            imageView = FindViewById<ImageView>(Resource.Id.imageView1);
            imageView.SetImageResource(Resource.Drawable.beerIconPng);
            buttonCam.Click += ButtonCam_Click;
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            Bitmap bitmap = (Bitmap)data.Extras.Get("data");
            imageView.SetImageBitmap(bitmap);
        }

        private void ButtonCam_Click(object sender, EventArgs a)
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            StartActivityForResult(intent, 0);
        }

        async void savebutton_ClickAsync(Object sender, EventArgs e)
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
                //-------------------------------------------------------------------------------------
                var dbFullPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Bars.db");
                var db = new BarContext(dbFullPath);

                try
                {
                    using (db)
                    {
                        // Entity
                        Bar bar = new Bar()
                        {
                            BarName = ((EditText)FindViewById(Resource.Id.barName)).Text,
                            RatingOfBar = (int)((RatingBar)FindViewById(Resource.Id.ratingOfBar)).Rating
                        };
                        List<Bar> barsInList = new List<Bar>() { bar };
                        await db.Bars.AddRangeAsync(barsInList);
                        await db.SaveChangesAsync();
                        // INSERT
                        //string barName = ((EditText)FindViewById(Resource.Id.barName)).Text;
                        //int ratingOfBar = (int)((RatingBar)FindViewById(Resource.Id.ratingOfBar)).Rating;
                        //db.Database.ExecuteSqlCommand("INSERT INTO [Bars] VALUES({0},{1})", barName, ratingOfBar);
                        //await db.SaveChangesAsync();
                    }

                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
                //-------------------------------------------------------------------------------------------
                Intent intent = new Intent(this, typeof(Results));
                Bundle bundle = new Bundle();
                bundle.PutString("name", ((EditText)FindViewById(Resource.Id.barName)).Text);
                bundle.PutInt("rating", (int)((RatingBar)FindViewById(Resource.Id.ratingOfBar)).Rating);
                intent.PutExtras(bundle);
                StartActivity(intent);

                FillUpWeb.FillUpWebService client = new FillUpWeb.FillUpWebService();
                bool value = client.AddBarReview(((EditText)FindViewById(Resource.Id.barName)).Text, 
                    (int)((RatingBar)FindViewById(Resource.Id.ratingOfBar)).Rating);
            }
            catch (BarNameEmptyException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            catch (RegexException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Toast.MakeText(Application.Context, "Įvyko klaida!", ToastLength.Long).Show();
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            
        }

        void gobackbutton_Click(Object sender, EventArgs e)
        {
            Finish();
        }
    }
}