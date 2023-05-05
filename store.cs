using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
            PurchaseItem();
        }

        static void Welcome()
        {
            Console.WriteLine("Welcome to the store!");
            Console.WriteLine("Book");
            Console.WriteLine("Shirt");
            Console.WriteLine("Computer");
            Console.WriteLine("What wold you like to buy?");
        }
        
        static void PurchaseItem()
        {
            var item = Console.ReadLine();
            switch(item)
            {
                case "Book":
                    var book= new Book();
                    book.Author = "JK author";
                    book.Title = "The wizard of coding";
                    book.Price = 9.99;
                    Console.WriteLine($"You purchase a {book.Title} for {book.Price}");
                    break;

                case "Shirt":
                    var shirt = new Shirt();
                    shirt.Size = "M";
                    shirt.Title = "Sports";
                    shirt.Price = 14.99;
                    Console.WriteLine($"You purchase a {shirt.Title} {shirt.Size} for {shirt.Price}");
                    break;

                case "Computer":
                    var computer = new Computer();
                    computer.Type = "PC";
                    computer.Title = "Asus";
                    computer.Price = 100;
                    Console.WriteLine($"You purchase a {computer.Title}" + $"{computer.Type} for {computer.Price}");
                    break;

                default:
                    break;
            }
        }
    }

    class BaseItem
    {
        public string Title{get; set;}
        public double Price{get; set;}
    }

    class Book : BaseItem
    {
        public string Author{get; set;}
    }

    class Shirt : BaseItem
    {
        public string Size{get; set;}
    }

    class Computer : BaseItem
    {
        public string Type{get; set;}
    }


}