using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using Xamarin.Forms;
using BD_SQLite1.iOS;
using System.IO;
using BD_SQLite1;
using UIKit;

[assembly: Dependency(typeof(ISQLite1_iOS))]

namespace BD_SQLite1.iOS
{
    public class ISQLite1_iOS : ISQLite
    {
    
        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, filename);
        }
    }
}