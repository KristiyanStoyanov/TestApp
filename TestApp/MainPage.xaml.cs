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
            this.Children.Add(new MainScreen());
            this.CurrentPageChanged += CurrentPageHasChanged;

            InitializeComponent();
        }
        protected void CurrentPageHasChanged(object sender, EventArgs e)
        {
            this.Title = this.CurrentPage.Title;
        }

    }
}
