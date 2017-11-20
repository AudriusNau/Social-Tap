using Android.App;
using Android.OS;
using Android.Widget;
using System;
using System.Collections.Generic;
using Fill_Up_App.Code;
using Fill_Up_App.localhost;

namespace Fill_Up_App
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

            localhost.FillUpWebService client = new localhost.FillUpWebService();
            string betterBars = client.FindBetterBarName(bar.BarName, bar.RatingOfBar);

            if(betterBars != null && betterBars.GetEnumerator().MoveNext())
            {
                a.Add("Siūlome jums apsilankyti geresniuose baruose:");
                //foreach (string n in betterBars)
                //{
                //    a.Add(n);
                //}                
            }
            else
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