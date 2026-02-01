using System;
using System.Collections.Generic;
using System.Text;

namespace librarymanagmentsystem
{
    public class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string isbn { get; set; }
        public bool availability { get; set; }

        public Book(string title, string author, string isbn, bool availability)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn; 
            this.availability = true;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {title}, Author: {author}, ISBN: {isbn}, Available: {availability}");
        }

    }    
    internal class book
    {
    }
}
