using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp
{
    public partial class About : ContentPage
    {
        public About()
        {
            InitializeComponent();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("mailto:kerainfosec@gmail.com"));
        }
    }
}