using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TestApp.ViewModel;
using TestApp.Models;
using System.IO;
using Xamarin.Forms;

namespace TestApp.View
{
    public partial class ContentViewPage : ContentPage
    {
        ContentViewModel vm;

        public ContentViewPage()
        {
            InitializeComponent();
            vm = new ContentViewModel();
            ContentList.ItemsSource = vm.ContentList;
        }

        async void Handle_ItemIsTapped(object sender, SelectedItemChangedEventArgs e)
        {
               if (e.SelectedItem == null) return;
                  ((ListView)sender).SelectedItem = null;

           await Navigation.PushAsync(new ContentPage());

        }
    }
}