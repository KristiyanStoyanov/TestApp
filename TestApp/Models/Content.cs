using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace TestApp.Models
{
    public class Content
    {
        /// Properties
        public string Category { get; set; }
        public string Text { get; set; }
        private static object sync = new object();

        /// Method to handle List of class objects 
        public List<Content> GetContent()
        {
            List<Content> libraryContent = new List<Content>()
            {

                   new Content() {Category="Wireless Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="A", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Web Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Hotspot Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="IdentityTheft", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Hotspot Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Hotspot Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Hotspot Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Hotspot Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Hotspot Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Hotspot Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Hotspot Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Hotspot Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Hotspot Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Hotspot Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Hotspot Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Hotspot Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Hotspot Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Hotspot Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Hotspot Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Hotspot Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Hotspot Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Hotspot Phishing", Text="Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content() {Category="Identity theft via web portals in Android", Text="Web phishing de" +
                    " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    " It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged." +
                    " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
                   new Content(){Category="Fake hotspot networks in coffee shops", Text="Famous cafeterias such as Starbucks" +
                       "Costa etc offer free internet to customers. Hackers sometime use the same network name you will see in" +
                       "your WiFi list an example of that is Starbucks' netowrk is named as #Starbucks but it can mistaken"}

            };

            foreach (var item in libraryContent)
            {
                Debug.WriteLine(item.Category);
            }

            return libraryContent;
        }
        public Content()
        {

        }

    }
}
