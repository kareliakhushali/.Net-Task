using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneCsharp
{
    class Admin 
    {
        Customer customer = new Customer();
         CategoryData cd = new CategoryData();
        SubcategoryData sd = new SubcategoryData();
        ProductData pd = new ProductData();

        public void Manage()
        {
           

            int choice;
            do
            {
                Console.WriteLine("\n===========Perform Operations=========");
                Console.WriteLine("\n1. Manage Category");
                Console.WriteLine("2. Manage Subcategory");
                Console.WriteLine("3. Manage Product");
                Console.WriteLine("4.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        cd.CategoryDataManage();
                        break;
                    case 2:
                        sd.SubCategoryDataManage();
                        break;
                    case 3:
                        pd.ProductDataManage();
                        break;
                    case 4:
                        break;
                }
            }
           
            while (choice != 4);
            Console.ReadKey();


        }
        /*  public void AddCategory()
          {
              List<string> Category = new List<string>();
              Category.Add("Men");
              Category.Add("Women");


          }
          public void UpdateCategory()
          {

          }
          public void DeleteCategory()
          {

          }*/
        /* public void ManageSubcategory()
         {
             int choice;
             do
             {
                 Console.WriteLine("\n===========Perform Operations=========");
                 Console.WriteLine("\n1. Add SubCategory");
                 Console.WriteLine("2. Upadate SubCategory ");
                 Console.WriteLine("3. Delete SubCategory");
                 choice = Convert.ToInt32(Console.ReadLine());
                 switch (choice)
                 {
                     case 1:
                         break;
                     case 2:
                         break;
                     case 3:
                         break;
                 }
             }

             while (choice != 3);

         }*/

        /* public void ManageProduct()
         {
             int choice;
             do
             {
                 Console.WriteLine("\n===========Perform Operations=========");
                 Console.WriteLine("\n1. Add Product");
                 Console.WriteLine("2. Upadate Product ");
                 Console.WriteLine("3. Delete Product");
                 choice = Convert.ToInt32(Console.ReadLine());
                 switch (choice)
                 {
                     case 1:
                         break;
                     case 2:
                         break;
                     case 3:
                         break;
                 }
             }

             while (choice != 3);



         }*/
    }
       
    }


