using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Text;

namespace C__Assignment
{

    class Book(string title, int pages)
    {
        public string Title = title;
        public int Pages  = pages;


    }
    class Program
    {
        static void Main(string[] args)
        {
            #region question 1

            // Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object.Print it

            //object obj = new Book("John Doe", 250);
            //Book a = (Book)obj;
            //Console.WriteLine(a.Title);
            //Console.WriteLine(a.Pages);
            //object obj2 = new Book("Jane Doe", 300);
            //Book b = (Book)obj2;
            //Console.WriteLine(b.Title);
            //Console.WriteLine(b.Pages);

            #endregion

            #region question 2
            // Q02.Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.

            //Book book1 = new Book("book1", 250);

            //Console.WriteLine(book1.ToString());

            //Console.WriteLine(book1.Equals(book1));
            //Console.WriteLine(book1.GetHashCode());

            //Console.WriteLine(book1.GetType());

            #endregion

            #region Question 3
            // Q03. Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.

            //int pages = "464"; its a compile-time error
            //int page = int.Parse("464");
            //Console.WriteLine(page);
            #endregion

            #region Question 4
            // Q04. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            int x = 10;
            int y = 0;
           //int result =x/y;
            int result;
            //Console.WriteLine(result);
            try
            {
                result = x / y;
                

            }
            catch (DivideByZeroException )
            {
                Console.WriteLine("Cannot divide by zero");
                
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion
        }
    }
}
