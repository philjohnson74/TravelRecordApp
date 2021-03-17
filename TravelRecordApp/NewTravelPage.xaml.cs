using System;
using System.Collections.Generic;
using SQLite;
using TravelRecordApp.Model;
using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        void ToolbarSave_Clicked(System.Object sender, System.EventArgs e)
        {
            Post post = new Post()
            {
                Experience = ExperienceEntry.Text
            };

            using(SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                int rows = conn.Insert(post);

                if (rows > 0)
                    DisplayAlert("Success", "Experience successfully inserted", "OK");
                else
                    DisplayAlert("Failure", "Experience failed to be inserted", "OK");
            }
        }
    }
}
