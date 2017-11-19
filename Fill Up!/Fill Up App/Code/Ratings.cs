using Android.App;
using Android.OS;
using Android.Widget;
using System;
using System.Collections.Generic;
using Fill_Up_App.localhost;

namespace Fill_Up_App
{
    [Activity(Label = "Fill Up!")]
    internal class Ratings : Activity
    {
        private ListView list;
        private List<string> list1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            localhost.FillUpWebService client = new localhost.FillUpWebService();
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RatingsLayout);

            list = FindViewById<ListView>(Resource.Id.listView2);
            list1 = new List<string>();

            list1.Add("Baras - Įvertinimas:");
            var ratings = client.GetSortedBarData();
            foreach(KeyValuePair < string, BarData> a in ratings)
            {
                list1.Add(a.Key + " - " + a.Value.RateAvg.ToString());
            }
            
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, list1);
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