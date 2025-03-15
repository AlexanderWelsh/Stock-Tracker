//Program 4
//CIS-199-50
//Due 12/4/2023
//By: A1029
//This file creates a simple test application class that creates an array of product objects and prints them first with their original data and then changes the data and prints the in stock units.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    internal class Program
    {
        //creates an object that will print all data found in the product class
        static void PrintData(Product[] products)
        {
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString() + "\n");
            }
        }
        static void Main(string[] args)
        {
            //creates each of the product objects and assigns it a variable  
            Product product1 = new Product("PepsiCo", "Gatorade", 675134, "Beverage", 3.50, 4);
            Product product2 = new Product("PepsiCo", "Gatorade", 675134, "Beverage", 3.50, 4);
            Product product3 = new Product("PepsiCo", "Gatorade", 675134, "Beverage", 3.50, 4);
            Product product4 = new Product("PepsiCo", "Gatorade", 675134, "Beverage", 3.50, 4);
            Product product5 = new Product("PepsiCo", "Gatorade", 675134, "Beverage", 3.50, 4);

            //creates five product objects and organizes them as lists of their attributes 
            Product[] products = new Product[]
            {
                new Product("PepsiCo", "Gatorade", 675134, "Beverage", 3.50, 4),
                new Product("Kellogg's", "Corn Flakes", 123456, "Cereal", 2.99, 8),
                new Product("Coca-Cola", "Coke", 789012, "Beverage", 1.99, 12),
                new Product("Campbell's", "Tomato Soup", 445566, "Canned Goods", 2.75, 3),
                new Product("Kraft", "Macaroni and Cheese", 990011, "Pasta", 1.99, 7),
            };

            Console.WriteLine("List of Products We Sell:\n");
            Console.WriteLine("---------------------------");
            PrintData(products);

            //makrs if each object is in stock and therefore gets printed at the end stage or not
            products[0].InStock();
            products[1].InStock();
            products[2].OutOfStock();
            products[3].InStock();
            products[4].OutOfStock();

            //changes items in the lists before they are printed as results
            products[0].ProductPrice = 4.00;
            products[2].Aisle = 12;
            products[3].ProductPrice = 3.20;
            products[4].ProductName = "Mac and Cheese";


            Console.WriteLine("After Changes\n");
            Console.WriteLine("---------------------------");

            //only prints items that are in stock
            foreach (var product in products)
            {
                if (!product.IsOutOfStock())
                {
                    Console.WriteLine(product.ToString() + "\n");
                }
            }
        }
    }
}
