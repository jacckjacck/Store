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
            Book cleanCode = new Book();

            //Setting the properties
            cleanCode.Title = "Clean code";
            cleanCode.Author = "Robert C. Martin";
            cleanCode.Editorial = "Anaya";

            //Other way for creating the instance of the class
            Book cleanArchitecture = new Book
            {
                Author = "Robert C. Martin",
                Editorial = "Anaya",
                Title = "Clean Architecture",
            };
            
            //Using the method AddStock to add more books to the store
            cleanCode.AddStock(10);

            //Throws an exception beacuse of negative value
            //cleanCode.Quantity=-10;

            Console.WriteLine($"The book {cleanCode.Title} has {cleanCode.Stock} items of stock");
            Console.WriteLine($"The book {cleanCode.Title} is signed by {cleanCode.Editorial}");

            Console.ReadLine();
        }
    }
}
