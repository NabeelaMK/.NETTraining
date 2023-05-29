using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            string bookTitle = "A tale of two cities";

            MyBook mybook = new MyBook();
            mybook.setTitle(bookTitle);

            Console.WriteLine("The title is: " + mybook.getTitle());

        }
    }

    public abstract class Book
    {
        protected string title;
        public abstract void setTitle(string str);

        public string getTitle()
        {
            return title;
        }
    }

    class MyBook: Book
    {
        public override void setTitle(string str)
        {
            title = str;
        }
    }
}
