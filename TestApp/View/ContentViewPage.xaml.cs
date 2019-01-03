using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TestApp.ViewModel;
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

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushModalAsync(new ContentPage());
        }
    }
}
