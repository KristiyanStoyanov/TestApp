using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TestApp.ViewModel;
using TestApp.Models;
using System.IO;
using Xamarin.Forms;
using System.Diagnostics;

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
            var item = e.SelectedItem as Content;
            //if (item == null)
            //return;
            //Content selected = e.SelectedItem as Content;
            if (((ListView)sender).SelectedItem == null)
                return;
            //Do stuff here with the SelectedItem ...
            ((ListView)sender).SelectedItem = null;

            await Navigation.PushAsync(new ContentDetailViewPage(new ContentDetailViewModel()));

        }
    }
}