using System;
using System.IO;
using JOURNAL.Data;
using JOURNAL.Tables;
using JOURNAL.Views;
using Xamarin.Forms;

namespace JOURNAL
{
    public partial class App : Application
    {

        static CityDatabase database;

        public static CityDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new CityDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Citys.db3"));
                }
                return database;
            }
        }



        static MemoryDatabase mdatabase;

        public static MemoryDatabase MDatabase
        {
            get
            {
                if (mdatabase == null)
                {
                    mdatabase = new MemoryDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Memories.db3"));
                }
                return mdatabase;
            }
        }


        //SETS FIRST PAGE THAT APPEARS WHEN APP STARTS
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
