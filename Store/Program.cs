using Store.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instance of the book class
            Book cleanCode = new Book("Clean code", "Robert C. Martin", "Anaya", 20);

            //Other way for creating the instance of the class
            Book cleanArchitecture = new Book
            (
                "Clean Architecture",
                "Robert C. Martin",
                "Anaya"
            );
            
            //Using the method AddStock to add more books to the store
            //cleanCode.AddStock(10);

            //Throws an exception beacuse of negative value
            //cleanCode.Quantity=-10;

            Console.WriteLine($"The book {cleanCode.Title} has {cleanCode.Stock} items of stock");
            Console.WriteLine($"The book {cleanCode.Title} is signed by {cleanCode.Editorial}");

            Console.ReadLine();
        }
    }
}
