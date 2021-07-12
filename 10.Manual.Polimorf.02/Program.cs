using System;
using System.Collections.Generic;
using Entities;
namespace _10.Manual.Polimorf._02 {
    class Program {
        static void Main(string[] args) {
            List<Product> list = new List<Product>(); // --- > Criando lista para os PRODUTOS

            Console.Write("Enter the number of prodcuts: "); int n = int.Parse(Console.ReadLine()); // --- > Add os dados A LISTA
            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Product #" + i + " data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (type == 'c' || type == 'C') {
                    list.Add(new Product(name, price));
                }
                else if (type == 'u' || type == 'U') {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                }

                Console.WriteLine();
                Console.WriteLine("PRICE TAGS:");
                foreach (Product prod in list) { // --- > Mostra os produtos da LISTA
                    Console.WriteLine(prod.PriceTag());
                }
            }
        }
    }
}
