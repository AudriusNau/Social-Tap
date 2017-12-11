using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FillUpApp.Standart;
using Microsoft.EntityFrameworkCore;

namespace Fill_Up_App.Code.Data
{
    public class DatabaseProcessing
    {
        public static async void DeleteFromTable()
        {
            var db = Database();

            try
            {
                using (db)
                {
                    await db.Database.MigrateAsync(); //We need to ensure the latest Migration was added. This is different than EnsureDatabaseCreated.

                    db.Database.ExecuteSqlCommand("DELETE FROM [Bars]");
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
        public static async void InsertToTable(string a, int b)
        {
            var db = Database();

            try
            {
                using (db)
                {
                    var barsInDatabase = await db.Bars.ToListAsync();
                    // Entity
                    Bar bar = new Bar()
                    {
                        BarName = a,
                        RatingOfBar = b
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

        }
        public static BarContext Database()
        {
            var dbFullPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Bars.db");
            var db = new BarContext(dbFullPath);
            return db;
        }
    }
}