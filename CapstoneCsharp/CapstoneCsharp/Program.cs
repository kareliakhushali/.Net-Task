using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneCsharp
{
    class Program
    {
            


        static void Main(string[] args)
        {
//            Products p = new Products(1, "Potato",  40, 2 );
           
         
            var Admin = new Admin();
          
            int choice;
            do
            {
                Console.WriteLine("\n===========Welcome to Shopify=========");
                Console.WriteLine("Choose an option");
                Console.WriteLine("1.Admin");
                Console.WriteLine("2.Customer");
                Console.WriteLine("3.Exit");
                choice = int.Parse(Console.ReadLine());
                



                switch (choice)
                {
                    case 1:

                        Admin.Manage();
                        break;
                    case 2:
                        
                        
                        break;
                    case 3:
                        break;




                }
            } while (choice != 3);
            Console.ReadKey();
            }

            //Console.ReadKey();
        }
        
    }

