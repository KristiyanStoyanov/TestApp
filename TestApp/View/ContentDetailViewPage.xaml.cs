using System;
using TestApp.Models;
using TestApp.ViewModel;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp.View
{
    public partial class ContentDetailViewPage : ContentPage
    {

        ContentDetailViewModel viewModel;

        public ContentDetailViewPage(ContentDetailViewModel viewModel)
        {
            BindingContext = this.viewModel = viewModel;
            InitializeComponent();
        }

        public ContentDetailViewPage()
        {
            InitializeComponent();
            viewModel = new ContentDetailViewModel();
            BindingContext = viewModel;
        }
    }
}
