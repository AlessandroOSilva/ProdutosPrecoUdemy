using ProdutosPreco.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProdutosPreco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int op = int.Parse(Console.ReadLine());

            List<Product> produtos = new List<Product>();

            for (int i = 1; i <= op; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char opc = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (opc == 'i' || opc == 'I')
                {
                    Console.Write("Customs fee: ");
                    double cf = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Product p = new ImportedProduct(cf, name, price);

                    produtos.Add(p);

                }
                else if (opc == 'u' || opc == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime md = DateTime.Parse(Console.ReadLine());
                    Product p = new UsedProduct(md, name, price);

                    produtos.Add(p);
                }
                else if(opc == 'c' || opc =='C')
                {
                    Product p = new Product(name, price);
                    produtos.Add(p);
                }
                else
                {
                    Console.WriteLine("Opção inválida. ");
                }

            }

            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in produtos)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
