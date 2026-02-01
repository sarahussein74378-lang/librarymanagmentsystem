using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace librarymanagmentsystem 
{

    public class Library
    {
        private List<Book> books =  new List<Book> ();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added successfully.");
        }
        public void SearchBook(string keyword)
        {
            bool found = false;

            foreach (Book book in books)
            {
                if (book.title.ToLower().Contains(keyword.ToLower()) ||
                    book. author.ToLower().Contains(keyword.ToLower()))
                {
                    book.DisplayInfo();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No books found.");
            }
        }
        public void BorrowBook(string isbn)
        {
            foreach (Book book in books)
            {
                if (book.isbn == isbn)
                {
                    if (book.availability)
                    {
                        book.availability = false;
                        Console.WriteLine("Book borrowed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Book is already borrowed.");
                    }
                    return;
                }
            }

            Console.WriteLine("Book not found.");
        }


        public void ReturnBook(string isbn)
        {
            foreach (Book book in books)
            {
                if (book.isbn == isbn)
                {
                    book.availability = true;
                    Console.WriteLine("Book returned successfully.");
                    return;
                }
            }

            Console.WriteLine("Book not found.");
        }
    }






























































    internal class libarary
    {
    }
}
