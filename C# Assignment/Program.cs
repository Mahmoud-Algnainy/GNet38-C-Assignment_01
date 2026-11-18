using System;
using System.Collections.Generic;
using System.Text;

namespace C__Assignment
{

    class Book(string title, int pages)
    {
        public string Title = title;
        public int Pages  = pages;

        //public override string ToString() => $"Book Title: {title}, Pages: {pages}";

    }
    class Program
    {
        static void Main(string[] args)
        {
            object obj  =new Book("John Doe", 250);
            Book a = (Book)obj;
            Console.WriteLine(a.Title);
            Console.WriteLine(a.Pages);
            object obj2 = new Book("Jane Doe", 300);
            Book b = (Book)obj2;
            Console.WriteLine(b.Title);
            Console.WriteLine(b.Pages);
        }
    }
}
