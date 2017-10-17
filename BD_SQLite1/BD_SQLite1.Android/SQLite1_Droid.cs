using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using System.IO;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using BD_SQLite1.Droid;
using BD_SQLite1;

[assembly: Dependency(typeof(SQLite1_Droid))]

namespace BD_SQLite1.Droid
{
    public class SQLite1_Droid: ISQLite

    {
        public string GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}