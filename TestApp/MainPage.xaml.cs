using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApp
{
    public partial class MainPage : TabbedPage
    {
     
        public MainPage()
        {
            this.Children.Add(new About());
            this.Children.Add(new Settings());        
            InitializeComponent();
        }

       private async void Button_Clicked(object sender, System.EventArgs e)
        {
            IsBusy = true;
            await Navigation.PushAsync(new MenuPage());
        }
    }
}
