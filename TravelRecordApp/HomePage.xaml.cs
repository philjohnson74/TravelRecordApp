using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void ToolbarAdd_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewTravelPage());
        }
    }
}
