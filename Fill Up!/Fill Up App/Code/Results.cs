using Android.App;
using Android.OS;
using Android.Widget;
using System;
using System.Collections.Generic;

namespace Fill_Up_App.Code
{
    [Activity(Label = "Fill Up!")]
    public class Results: Activity
    {
        private ListView list;
        private List <string> a;

        private Lazy<Results> _lazyProperty = new Lazy<Results>(() => new Results());

        public Results MyProperty
        {
            get
            {
                return _lazyProperty.Value;
            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ResultsLayout);
            BarReview bar = new BarReview(Intent.GetStringExtra("name"), Intent.GetIntExtra("rating", -1));

            list = FindViewById<ListView>(Resource.Id.listView1);
            a = new List<string>();
            a.Add("Baras:" + " " + bar.BarName);
            a.Add("Įvertinimas:" + " " + bar.RatingOfBar.ToString());
            a.Add("");

            FillUpWeb.FillUpWebService client = new FillUpWeb.FillUpWebService();
            string betterBar = client.FindBetterBarName(bar.BarName, bar.RatingOfBar);

            if(betterBar != null && betterBar != bar.BarName)
            {
                a.Add("Siūlome jums apsilankyti:" + betterBar);             
            }
            else if(betterBar == bar.BarName)
            {
                a.Add("Jūsų baras puikus!");
            }

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, a);
            list.Adapter = adapter;

            Button gobackbutton = FindViewById<Button>(Resource.Id.goBackBut);
            gobackbutton.Click += new EventHandler(this.gobackbutton_Click);
        }

        void gobackbutton_Click(Object sender, EventArgs e)
        {
            Finish();
        }
    }
}