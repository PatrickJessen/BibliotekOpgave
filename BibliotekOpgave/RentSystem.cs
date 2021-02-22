using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekOpgave
{
    class RentSystem
    {
        Stack<Book> rentedBooks = new Stack<Book>();
        List<Book> forRent = new List<Book>();
        int userinput;
        public void AddBooksForRent()
        {
            forRent.Add(new Book("Harry Potter 1", "J.K Rowling", 642, 2001));
            forRent.Add(new Book("Harry Potter 2", "J.K Rowling", 457, 2002));
            forRent.Add(new Book("Harry Potter 3", "J.K Rowling", 747, 2004));
            forRent.Add(new Book("Harry Potter 4", "J.K Rowling", 581, 2005));
            forRent.Add(new Book("Harry Potter 5", "J.K Rowling", 810, 2007));
        }

        public void ShowBooks()
        {
            Console.Clear();
            for (int i = 0; i < forRent.Count; i++)
            {
                Console.WriteLine(i+1 + ". " + forRent[i].Title);
            }
        }

        public void SelectBookToRent()
        {
            AddBooksForRent();
            while (forRent.Count != 0)
            {

                ShowBooks();
                userinput = int.Parse(Console.ReadLine());
                switch (userinput)
                {
                    case 1:
                        rentedBooks.Push(forRent[0]);
                        forRent.RemoveAt(0);
                        ShowBooks();
                        break;
                    case 2:
                        rentedBooks.Push(forRent[1]);
                        forRent.RemoveAt(1);
                        ShowBooks();
                        break;
                    case 3:
                        rentedBooks.Push(forRent[2]);
                        forRent.RemoveAt(2);
                        ShowBooks();
                        break;
                    case 4:
                        rentedBooks.Push(forRent[3]);
                        forRent.RemoveAt(3);
                        ShowBooks();
                        break;
                    case 5:
                        rentedBooks.Push(forRent[4]);
                        forRent.RemoveAt(4);
                        ShowBooks();
                        break;
                    default:
                        break;
                }
            }
            while (rentedBooks.Count != 0)
            {
                Console.Clear();
                Console.ReadKey();
                Console.WriteLine(rentedBooks.Peek().Title);
                Console.WriteLine("Press any key to confirm");
                Console.ReadKey();
                Console.WriteLine("Books has now been rented to you");
                rentedBooks.Pop();
                Console.ReadKey();
            }
        }
    }
}
