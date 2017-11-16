using Android.App;
using Android.OS;
using Android.Widget;
using System;
using System.Collections.Generic;
using Fill_Up_App.Code;
using Fill_Up_.Code;

namespace Fill_Up_App
{
    [Activity(Label = "Fill Up!")]
    public class Results: Activity
    {
        private ListView list;
        private List <string> a;
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ResultsLayout);

            ListsOfBars allBars = new ListsOfBars();

            GlassOfBeer glass = new GlassOfBeer(Intent.GetDoubleExtra("mug", -1), Intent.GetIntExtra("lack", -1), Intent.GetDoubleExtra("price", -1).DoubleToDecimal());
            VisitedBar bar = new VisitedBar(Intent.GetStringExtra("name"), Intent.GetIntExtra("rating", -1), glass);

            allBars.AddNewBar(bar);

            list = FindViewById<ListView>(Resource.Id.listView1);
            a = new List<string>();
            a.Add("Jūsų duomenys:");
            a.Add("Baras - " + bar.Name);
            a.Add("Užsakytas kiekis - " + bar.Glass.OrderedQuantity.ToString());
            a.Add("Neįpilta - " + bar.Glass.LackOfBeer.ToString());
            a.Add("Kaina - " + bar.Glass.Price.ToString());
            a.Add("Įvertinimas - " + bar.Rating.ToString());
            a.Add(" ");

            var betterBars = allBars.GetBetterBars(bar); //ka jei tuscias
            if (betterBars != null && betterBars.GetEnumerator().MoveNext())
            {
                a.Add("Siūlome Jums apsilankyti:");
                foreach (string m in betterBars)
                {
                    a.Add(m);
                }
            }
            else
                a.Add("Aplankytas baras puikus!");

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