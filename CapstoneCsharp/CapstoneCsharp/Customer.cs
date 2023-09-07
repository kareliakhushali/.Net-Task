using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneCsharp
{
    class Customer
    {
        public void PerformOperations()
        {
            int choice;
            do
            {
                Console.WriteLine("\n===========Perform Operations=========");
                Console.WriteLine("\n1.View product");
                Console.WriteLine("2. Make - Order");
                Console.WriteLine("3. View Bill");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                       // ViewProducts(productList);
                        break;
                    case 2:
                       
                        break;
                    case 3:
                      
                        break;
                }
            }

            while (choice != 3);
        }
        public void ViewProducts(List<Products> productList)
        {

            foreach (Products product in productList)
            {
                Console.WriteLine(product.ProductName + " - " + product.Price);
            }

            /*public static void MakeOrder()
             {
                Console.WriteLine()

             }*/

            /* public void ViewBill()
             {

             }
*/
        }
    }
}
