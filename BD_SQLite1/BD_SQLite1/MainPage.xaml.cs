using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace BD_SQLite1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SQLiteAsyncConnection database;
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("Datos_Registro.db");
            database = new SQLiteAsyncConnection(db);
            database.CreateTableAsync<Datos_Registro>().Wait();

       }
    }
}
