﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TestApp.Models;
using TestApp.View;
using TestApp.ViewModel;
using System.Collections;
using System.Text;
using System.Linq;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TestApp
{
    public partial class App : Application
    {

        public App()
        {
            
            MainPage = new NavigationPage(new MainPage());
            InitializeComponent();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
