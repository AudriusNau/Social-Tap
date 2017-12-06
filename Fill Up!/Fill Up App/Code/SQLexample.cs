using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Threading;
using QC = System.Data.SqlClient;
using System.Data.SqlClient;

namespace Fill_Up_App.Code
{
    [Activity(Label = "Fill Up!")]
    public class SQLexample : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            //SqlConnection myConnection = new SqlConnection("user id=adminuser;" +
            //                       "password=Fillupapp1;" +
            //                       "server=fillupappdbserver1.database.windows.net,1433;" +
            //                       "Trusted_Connection=yes;" +
            //                       "database=FillUpApp_db1; " +
            //                       "connection timeout=30");
            //try
            //{
            //    myConnection.Open();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}

            //SqlCommand myCommand = new SqlCommand(@"INSERT INTO Bar (BarName, RatingOfBar) " +
            //                         "VALUES ('Ruta', 2)", myConnection);
            //myCommand.ExecuteNonQuery();

            //try
            //{
            //    myConnection.Close();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}

            //SqlConnection myConnection = new SqlConnection("Server=tcp:fillupappdbserver1.database.windows.net,1433;" +
            //    "Initial Catalog=FillUpApp_db1;" +
            //    "Persist Security Info=False;" +
            //    "User ID=adminuser;Password=Fillupapp1;" +
            //    "MultipleActiveResultSets=False;Encrypt=True;" +
            //    "TrustServerCertificate=False;Connection Timeout=30;");

            //myConnection.Open();

            //myConnection.Close();

            try
            {
                var cb = new SqlConnectionStringBuilder();
                cb.DataSource = "tcp:fillupappdbserver1.database.windows.net,1433";
                cb.UserID = "adminuser";
                cb.Password = "Fillupapp1";
                cb.InitialCatalog = "FillUpApp_db1";

                using (var connection = new SqlConnection(cb.ConnectionString))
                {
                    connection.Open();

                    //Submit_Tsql_NonQuery(connection, "2 - Create-Tables",
                    //   Build_2_Tsql_CreateTables());

                    //Submit_Tsql_NonQuery(connection, "3 - Inserts",
                    //   Build_3_Tsql_Inserts());

                    //Submit_Tsql_NonQuery(connection, "4 - Update-Join",
                    //   Build_4_Tsql_UpdateJoin(),
                    //   "@csharpParmDepartmentName", "Accounting");

                    //Submit_Tsql_NonQuery(connection, "5 - Delete-Join",
                    //   Build_5_Tsql_DeleteJoin(),
                    //   "@csharpParmDepartmentName", "Legal");

                    //Submit_6_Tsql_SelectEmployees(connection);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("View the report output here, then press any key to end the program...");
            Console.ReadKey();
        }
    }
}