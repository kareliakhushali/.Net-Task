using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16_03_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create List
            List<Product> products = new List<Product>();
            products.Add(new Product() { Id = 8, Name = "Potato", Qty = 1, Rate = 60, Category = "Vegetables" });
            products.Add(new Product() { Id = 4, Name = "Mango", Qty = 2, Rate = 80, Category = "Fruits" });
            products.Add(new Product() { Id = 1, Name = "Mobile", Qty = 3, Rate = 20000, Category = "Electronics" });
            products.Add(new Product() { Id = 7, Name = "Tomato", Qty = 2, Rate = 40, Category = "Vegetables" });
            products.Add(new Product() { Id = 9, Name = "Apple", Qty = 2, Rate = 60, Category = "Fruits" });
            products.Add(new Product() { Id = 6, Name = "Camera", Qty = 2, Rate = 15000, Category = "Electronics" });
            products.Add(new Product() { Id = 3, Name = "Carrot", Qty = 2, Rate = 50, Category = "Vegetables" });
            products.Add(new Product() { Id = 10, Name = "Banana", Qty = 2, Rate = 40, Category = "Fruits" });
            products.Add(new Product() { Id = 2, Name = "TV", Qty = 4, Rate = 25000, Category = "Electronics" });
            products.Add(new Product() { Id = 5, Name = "Grapes", Qty = 2, Rate = 20, Category = "Fruits" });
            Console.WriteLine("List of the products in the collection");
            foreach (Product p in products)
            {
                Console.WriteLine("{0, -2},{1,-10} {2,-5} {3,-6} {4,-5}", p.Id, p.Name, p.Qty, p.Rate, p.Category);
            }
            Console.WriteLine();
            Product[] products1 = new Product[products.Count];
            products.CopyTo(products1);
            Array.Sort(products1);
            Console.WriteLine("List of Products - After using Icomparable");
            foreach (Product p in products1)
            {
                Console.WriteLine("{0, -2},{1,-10} {2,-5} {3,-6} {4,-5}", p.Id, p.Name, p.Qty, p.Rate, p.Category);
            }
            Console.WriteLine();
            Console.WriteLine("Original Data");
            foreach (Product p in products)
            {
                Console.WriteLine("{0, -2},{1,-10} {2,-5} {3,-6} {4,-5}", p.Id, p.Name, p.Qty, p.Rate, p.Category);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            Console.Clear();
            //LINQ
            var Name = from p in products
                       orderby p.Name
                       select p;
            Console.WriteLine("List of Products Sort by Name");
            foreach (Product p in Name)
            {
                Console.WriteLine("{0, -2},{1,-10} {2,-5} {3,-6} {4,-5}", p.Id, p.Name, p.Qty, p.Rate, p.Category);
            }
            Console.WriteLine(); var Qty = from p in products
                                           orderby p.Qty
                                           select p;
            Console.WriteLine("List of Products Sort by Quantity");
            foreach (Product p1 in Qty)
            {
                Console.WriteLine("{0, -2},{1,-10} {2,-5} {3,-6} {4,-5}", p1.Id, p1.Name, p1.Qty, p1.Rate, p1.Category);
            }
            Console.WriteLine();
            var Rate = from p in products
                       orderby p.Rate
                       select p;
            Console.WriteLine("List of Products Sort by Rate");
            foreach (Product p2 in Rate)
            {
                Console.WriteLine("{0, -2},{1,-10} {2,-5} {3,-6} {4,-5}", p2.Id, p2.Name, p2.Qty, p2.Rate, p2.Category);
            }
            Console.WriteLine();
            var Category = from p in products
                           orderby p.Category
                           select p;
            Console.WriteLine("List of Products of Category wise");
            foreach (Product pc in Category)
            {
                Console.WriteLine("{0, -2},{1,-10} {2,-5} {3,-6} {4,-5}", pc.Id, pc.Name, pc.Qty, pc.Rate, pc.Category);
            }
            Console.WriteLine();
        }
    }
}
