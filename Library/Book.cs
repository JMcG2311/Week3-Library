using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        //Private fields
        private string _title;
        private string _author;
        private int _isbn;

        //Public properties
        public string Title
        {
            get { return _title; }
            set { _title = value; }
             
        }

        public string Author
        {
            get { return _author; }
            set
            {
                //Check if character 
            }
        }
        

        public int ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
      

        //Parameterised constructor
        public Book(string bookTitle, string bookAuthor, int bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }
        //Method to display book information
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
