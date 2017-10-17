using Xamarin.Forms;
using Windows.Storage;
using BD_SQLite1.UWP;
using System.IO;
using BD_SQLite1;

[assembly: Dependency(typeof(ISQLite1_UWP))]

namespace BD_SQLite1.UWP
{
    public  class ISQLite1_UWP: ISQLite
    {
        public string GetLocalFilePath(string filename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
        }
    }
}
