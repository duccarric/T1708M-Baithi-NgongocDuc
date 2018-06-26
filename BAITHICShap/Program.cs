using System;
using System.Collections.Generic;
using System.Text;
using BAITHICShap.Properties;

namespace BAITHICShap
{
    internal class Program
    {
        private static List<Product> list = new List<Product>();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Add product records");
                Console.WriteLine("2.Display product records");
                Console.WriteLine("3.Delete product by Id");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Please input your choice ");
                int ans = Int32.Parse(Console.ReadLine());

                switch (ans)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Display();
                        break;
                    case 3:
                        delete();
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                }
            }
        }

        private static void delete()
        {
            Console.WriteLine("Nhap Product ID :");
            string id = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
               
                if (list[i].ProductId.Equals(id))
                {
                    list.RemoveAt(i);
                }
            }
        }


        private static void Display()
        {
           
            
            Console.WriteLine("Dispaly product");
            Console.WriteLine("{0, -20}{1, -20}{2, -20}","Product ID","Product Name", "Price");
            Console.WriteLine("--------------------------------------------------------------");
            foreach (var i in list)
            {
                Console.WriteLine("{0,-20}{1,-20}{2,-20}",i.ProductId, i.ProductName, i.ProductPrice);
            }
        }

        private static void Add()
        {
            while (true)
            {
                Console.WriteLine("nhap ProductID: ");
                string productID = Console.ReadLine();
                Console.WriteLine("nhap name of product: ");
                string productName = Console.ReadLine();
                Console.WriteLine("nhap price: ");
                string productPrice = Console.ReadLine();
                Product product = new Product(productID, productName, productPrice);
                list.Add(product);
                Console.WriteLine("ban co muon nhap tiep khong(y/n)");
                string answers = Console.ReadLine();
                if (answers.Equals("n"))
                {
                    break;
                }
            }
        }
    }
}