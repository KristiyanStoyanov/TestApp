using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TestApp.Models;
using TestApp.ViewModel;

namespace TestApp.ViewModel
{
    public class ContentDetailViewModel
    {
        public Content ModelItem { get; set; }

        public ContentDetailViewModel(Content content = null)
        {
            ModelItem = content;

        }
    }
}