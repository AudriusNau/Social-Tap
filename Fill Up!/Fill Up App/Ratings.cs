using Android.App;
using Android.OS;
using Android.Widget;
using System;
using System.Collections.Generic;

namespace Fill_Up_App
{
    [Activity(Label = "Fill_Up_App")]
    internal class Ratings : Activity
    {
        private ListView list;
        private List<string> a;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RatingsLayout);
            int number = 5;
            list = FindViewById<ListView>(Resource.Id.listView2);
            a = new List<string>();
            a.Add("Baras" + number.ToString());
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