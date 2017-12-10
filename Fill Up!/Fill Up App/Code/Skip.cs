using Android.App;
using Android.OS;
using Android.Widget;
using FillUpApp.Standart;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Fill_Up_App.Code
{
    [Activity(Label = "Fill Up!")]
    public class Skip : Activity
    {
        private ListView list;
        private List<string> a;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SetLayout);

            if(Intent.GetIntExtra("metodas", -1) == 1)
            {
                DoSkip();
            }else if(Intent.GetIntExtra("metodas", -1) == 2)
            {
                DoTake();
            }else if(Intent.GetIntExtra("metodas", -1) == 3)
            {
                DoAgregate();
            }
            else if (Intent.GetIntExtra("metodas", -1) == 4)
            {
                DoGroup();
            }

            Button gobackbutton = FindViewById<Button>(Resource.Id.goBackBut);
            gobackbutton.Click += new EventHandler(this.gobackbutton_Click);
        }

        void gobackbutton_Click(Object sender, EventArgs e)
        {
            Finish();
        }

        async void DoSkip()
        {
            list = FindViewById<ListView>(Resource.Id.listView1);
            a = new List<string>();
            a.Add("Visi barai, išskyrus pirmąjį:");

            var dbFullPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Bars.db");
            var db = new BarContext(dbFullPath);

            try
            {
                using (db)
                {
                    var barsInDatabase = await db.Bars.ToListAsync();
                    var barai = barsInDatabase.Skip(1);

                    foreach (var bar in barai)
                    {
                        a.Add($"{bar.BarName}       {bar.RatingOfBar} \u2605" + System.Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, a);
            list.Adapter = adapter;
        }

        async void DoTake()
        {

        }

        async void DoAgregate()
        {

        }

        async void DoGroup()
        {

        }
    }
}