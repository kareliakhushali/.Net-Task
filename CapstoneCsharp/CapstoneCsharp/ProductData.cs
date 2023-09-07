using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CapstoneCsharp
{
    class ProductData
    {
        Products pd;
         
        List<Products> productList = new List<Products>();
        public void ProductDataManage()
        {
            int choice;
            do
            {
                Console.WriteLine("\n===========Perform Operations=========");
                Console.WriteLine("\n1. Add Product");
                Console.WriteLine("2. Update Product");
                Console.WriteLine("3. Delete Product");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:


                        AddProduct();

                        Display();
                        break;
                    case 2:
                        UpdateCategory();
                      

                      //  Console.WriteLine("Category List");


                        /*Console.WriteLine("Enter the old category name: ");
                        string oldCategory = Console.ReadLine()
                        Console.WriteLine("Enter the new category name: ");
                        string newCategory = Console.ReadLine();
                        UpdateCategory(oldCategory, newCategory);
                        Display();*/
                        break;
                    case 3:

                        Console.WriteLine("Enter index which you want to delete");
                        int index_id = Convert.ToInt32(Console.ReadLine());
                        DeleteCategory(index_id - 1);
                        Display();
                        break;
                }
            }
            while (choice != 3);
        }
        public void AddProduct()
        {
            

            /*

                        if (int.TryParse(temp_pid, out int ProductId))
                        {
                            // If parsing is successful, the input is a valid product ID
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Product ID: " + ProductId);
                        }
                        else
                        {
                            // If parsing fails, the input is not a valid product ID
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid product ID");
                        }*/



            Console.WriteLine("Enter Product ID :");
           // int temp_pid = Convert.ToInt32(Console.ReadLine());
            int temp_pid;

            while (!int.TryParse(Console.ReadLine(), out temp_pid))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer value for the Product ID:");
            }
            Console.WriteLine("Enter Product Name:");
            string temp_pname = Console.ReadLine();

            Console.WriteLine("Enter Product quantity :");
            int temp_pqnty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Price");
            int temp_price = Convert.ToInt32(Console.ReadLine());
            Products p = new Products(temp_pid, temp_pname,temp_pqnty,temp_price);
            productList.Add(p);
            Console.WriteLine("Product added successfully....:");
            //   categoryList.Add(add_category);
        }

        public void UpdateCategory()
        {
            Display();
            Console.WriteLine("Enter index which you want to update : ");
            int index = Convert.ToInt32(Console.ReadLine());
            //  UpdateCategory(index);
            Products p = productList[index-1];
            string updated_name;
            int updated_qty;
            int updated_price;

            Console.WriteLine($" Product ID : {p.ProductId}  Product Name : {p.ProductName} Product Quantity : {p.Quantity} Product Price:{p.Price} ");
            Console.WriteLine("Do You want to update product name ? Yes/No ");

            string temp = Console.ReadLine();
            

             if (temp.ToLower().Equals("yes"))
             {
                 Console.WriteLine("Enter your updated name");
                 updated_name = Console.ReadLine();
             }
            else 
            {
                updated_name = p.ProductName; // keep the current name
            }
            



            Console.WriteLine("Do You want to update product Quantity ? Yes/No ");

            string temp1 = Console.ReadLine();
            
            if (temp1.ToLower().Equals("yes"))
            {
                Console.WriteLine("Enter your updated quantity");
                updated_qty = Convert.ToInt32(Console.ReadLine());
            }
            else
            {

                updated_qty = p.Quantity;

            }



            Console.WriteLine("Do You want to update product price ? Yes/No ");

            string temp2 = Console.ReadLine();
            if (temp2.ToLower().Equals("yes"))
            {
                Console.WriteLine("Enter your updated Price");
                updated_price = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                updated_price = p.Price;

            }
            p.ProductName = updated_name;
           p.Quantity = updated_qty;
            p.Price = updated_price;
            /*            Console.WriteLine($" Product ID : {p.ProductId}  Product Name : {p.ProductName} Product Quantity : {p.Quantity} ");
            */
            productList[index-1] = p;
            Console.WriteLine("============Updated data==========");
            Display();



            /* int index = categoryList.IndexOf(oldCategory);
             if (index != -1)
             {
                 categoryList[index] = newCategory;
             }*/
        }
        public void DeleteCategory(int delete_product)
        {
            productList.RemoveAt(delete_product);
            Console.WriteLine("Product Deleted succesfully....:");

        }
        public void Display()
        {
            int num = 1;

            foreach (Products pd in productList)
            {
                Console.WriteLine($"Index = {num} Product ID : {pd.ProductId}  Product Name : {pd.ProductName} Product Quantity : {pd.Quantity} Product Price:{pd.Price}");
                num++;
            }
        }
    }
}
