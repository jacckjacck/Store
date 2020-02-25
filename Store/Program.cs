using Store.Classes;
using System;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instance of the book class
            Book cleanCode = new Book("Clean code", "Robert C. Martin", "Anaya", 150000, 20);

            //Other way for creating the instance of the class
            Book cleanArchitecture = new Book
            (
                "Clean Architecture",
                "Robert C. Martin",
                "Anaya",
                200000
            );

            //Using the method AddStock to add more books to the store
            cleanCode.AddStock(10);

            //Adding quantities of the product to buy
            cleanCode.Quantity = 10;

            //Throws an exception beacuse of negative value
            //cleanCode.Quantity=-10;

            Console.WriteLine($"The book {cleanCode.Description} has {cleanCode.Stock} items of stock");
            Console.WriteLine($"The book {cleanCode.Description} is signed by {cleanCode.Editorial}");
            Console.WriteLine($"The total for the book {cleanCode.Description} is signed by {cleanCode.GetTotal().ToString()}");

            //Instance of new surface laptop
            SurfaceLaptop surfaceLaptop = new SurfaceLaptop("Surface W10 Intel Core i9", 40, 3000000);

            //Adding quantities of the product to the buy
            surfaceLaptop.Quantity = 10;

            Console.WriteLine($"The total for the laptop {surfaceLaptop.Description} is {surfaceLaptop.GetTotal().ToString()}");

            Console.ReadLine();
        }
    }
}
