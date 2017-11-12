using Android.App;
using Android.OS;
using Android.Widget;
using System;
using System.Collections.Generic;

namespace Fill_Up_App
{
    [Activity(Label = "Fill_Up_App")]
    public class Results: Activity
    {
        private ListView list;
        private List <string> a;
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ResultsLayout);

            list = FindViewById<ListView>(Resource.Id.listView1);
            a = new List<string>();
            a.Add("Baras:" + " ");
            a.Add("Užsakytas kiekis:" + " ");
            a.Add("Neįpilta:" + " ");
            a.Add("Kaina:" + " ");
            a.Add("Įvertinimas:" + " ");
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, a);
            list.Adapter = adapter;

        }
    }
}