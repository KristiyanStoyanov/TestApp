using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    public class ContentViewModel
    {

        public string Name { get; set; }
        public string Content { get; set; }

        public Obso<ContentViewModel> myList;

        public ContentViewModel(ContentViewModel content)
        {

            myList = new List<ContentViewModel>();
            foreach(var i in myList)
            {
                myList.Add(i);
            }

        }
    }
}
