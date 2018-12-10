using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp
{
    public partial class MainScreen : ContentPage
    {

        public MainScreen()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage());
        }
    }
}

