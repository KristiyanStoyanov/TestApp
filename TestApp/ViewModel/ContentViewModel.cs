using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestApp.Models;

namespace TestApp.ViewModel
{
    public class ContentViewModel
    { 
        public List<Content> ContentList { get; set; }

        public ContentViewModel()
        {
            ContentList = new Content().GetContent();
        }
 
    }
}
