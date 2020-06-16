using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper2
{
    class Books
    {
        string bookName;
        long bookID;
        public Books(string name, int value)
        {
            bookName = name;
            bookID = value;
        }
        public string BookName
        {
            get
            {
                return bookName;
            }

        }
        public long BookID
        {
            get
            {
                return bookID;
            }

        }
    }
    class BookStore
    {
        static void Main(string[] args)
        {
            Books obj = new Books("DucNHudaik", 1020);
            Console.WriteLine("Bookname: " + obj.BookName);
            Console.Read();
        }
    }
}
