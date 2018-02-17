using System;
using System.Collections.Generic;
using System.Collections;

namespace BookCollection
{
    class Books
    {
        /// <summary>
        /// Performs the Stack operation for collection of books.
        /// </summary>
        public void ArrangingBooks()
        {
            Console.WriteLine("Books in a Box");
            Stack book = new Stack();
            Console.WriteLine("\nEnter the number of books to put into the box:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the names of the books:");
            for (int index = 0; index < number; index++)
            {
                string bookName = Console.ReadLine();
                book.Push(bookName); 
            }
            
            Console.WriteLine("\nArrangement of books in the box are:");
            foreach (var index in book)
            {
                Console.WriteLine(" " + index);
            }

            Console.WriteLine("\nEnter number of books to be taken out of the box:");
            int remove = Convert.ToInt32(Console.ReadLine());
            for (int index = 0; index < remove; index++)
            {
                book.Pop();
            }
         
            Console.WriteLine("\nBooks in the box after taking out {0} books are:",remove);
            foreach (var stackValue in book)
            {
                Console.WriteLine(" " + stackValue);
            }
            Console.ReadKey();
        }
    }
}
