using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MobileAssigenment2;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(MobileAssigenment2.Droid.SQL_Android))]
namespace MobileAssigenment2.Droid
{
    public class SQL_Android : ISQLite
    {
        public SQLiteConnection GetConnection(string dbName)
        {

            var dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = System.IO.Path.Combine(dbPath, dbName);
            var conn = new SQLiteConnection(path);
            return conn;
        }
    }
}