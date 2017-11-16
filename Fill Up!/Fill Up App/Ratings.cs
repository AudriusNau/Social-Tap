using Android.App;
using Android.OS;
using Android.Widget;
using System;
using System.Collections.Generic;
using Fill_Up_App.Code;

namespace Fill_Up_App
{
    [Activity(Label = "Fill Up!")]
    internal class Ratings : Activity
    {
        private ListView list;
        private List<string> a;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RatingsLayout);

            ListsOfBars allBars = new ListsOfBars();

            List<RatedBar> x = allBars.GetRatings();
            a = new List<string>();

            foreach (RatedBar bar in x)
            {
                a.Add(bar.Name + bar.Rating.ToString());
            }

            list = FindViewById<ListView>(Resource.Id.listView2);
            
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, a);
            list.Adapter = adapter;

            Button gobackbutton = FindViewById<Button>(Resource.Id.goBackButton1);
            gobackbutton.Click += new EventHandler(this.gobackbutton_Click);
        }
        
        void gobackbutton_Click(Object sender, EventArgs e)
        {
            Finish();
        }
    }
}