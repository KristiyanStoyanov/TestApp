using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Models
{
    public class Content
    {
        public string Category { get; set; }
        public string Text { get; set; }

        public List<Content> GetContent()
        {
            List<Content> libraryContent = new List<Content>()
            {
                new Content() {Category="Costa Hotspot", Text="Legitimate Network"},
                new Content() {Category="Costa Hotspot", Text="How to check"},
                new Content() {Category="Costa Hotspot", Text="Phishing Method 1"},
                new Content() {Category="Starbucks Hotspot", Text="Legitimate network"},
                new Content() {Category="Starbucks Hotspot", Text="What to check"},
                new Content() {Category="Starbucks Hotspot", Text="Phishing Method 1"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"},
                new Content() {Category="Wireless Phishing", Text="Loren Ipsum"}

            }; 
            return libraryContent;
        }

        public Content()
        {
        }

    }
}
