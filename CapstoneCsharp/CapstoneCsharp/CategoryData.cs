using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneCsharp
{
    class CategoryData
    {
        Category cd;
        List<Category> categoryList = new List<Category>();
        
        public void CategoryDataManage()
        {
            int choice;
            do
            {
                Console.WriteLine("\n===========Perform Operations=========");
                Console.WriteLine("\n1. Add Category");
                Console.WriteLine("2. Update Category");
                Console.WriteLine("3. Delete Category");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                       

                            AddCategory();
                       
                        Display();
                        /*Console.Write("Enter a new category or press enter to quit: ");
                        Console.ReadLine();
                        string newCategory = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(newCategory))
                        {
                            break;
                        }
                        categoryList.Add(newCategory);
                        Console.WriteLine($"Added {newCategory} to categories.");*/



                        break;
                    case 2:

                        
                        UpdateCategory();
                      
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
        public void AddCategory()
        {
            

                Console.WriteLine("Enter Category ID :");

          //  int temp_id = Convert.ToInt32(Console.ReadLine());
            int temp_id;

            while (!int.TryParse(Console.ReadLine(), out temp_id))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer value for the Category ID:");
            }
            Console.WriteLine("Enter Category Name:");
            string temp_name = Console.ReadLine();

            bool nameExists = false;
            foreach (Category existingCategory in categoryList)
            {
                if (existingCategory.CategoryName == temp_name)
                {
                    nameExists = true;
                    break;
                }
            }

            if (nameExists)
            {
                Console.WriteLine("Error: Category with this name already exists.");
            }
            else
            {
                Category c = new Category(temp_id, temp_name);
                categoryList.Add(c);
                 Console.WriteLine("Category added successfully....:");
              
            }


            // Category c = new Category(temp_id, temp_name);
            //   categoryList.Add(c);
            // Console.WriteLine("Category added successfully....:");
            //   categoryList.Add(add_category);
        }

        public void UpdateCategory()
        {
            Display();
            Console.WriteLine("Enter index which you want to update : ");
            int index = Convert.ToInt32(Console.ReadLine());
            //  UpdateCategory(index);
            Category c = categoryList[index - 1];
            string updated_name;
           

            Console.WriteLine($" Category ID : {c.CategoryId}  Category Name : {c.CategoryName}  ");
            Console.WriteLine("Do You want to update category name ? Yes/No ");

            string temp = Console.ReadLine();
            if (temp.ToLower().Equals("yes"))
            {
                Console.WriteLine("Enter your updated name");
                updated_name = Console.ReadLine();
            }
            else
            {
                updated_name = c.CategoryName;

            }
            c.CategoryName = updated_name;
            categoryList[index - 1] = c;
            Console.WriteLine("============Updated data==========");
            Display();
            /* int index = categoryList.IndexOf(oldCategory);
             if (index != -1)
             {
                 categoryList[index] = newCategory;
             }*/
        }
        public void DeleteCategory(int delete_category)
        {
            categoryList.RemoveAt(delete_category);
            Console.WriteLine("Deleted....:");

        }
        public void Display()
        {
            int num = 1;

            foreach ( Category cd in categoryList)
            {
                Console.WriteLine($"Index = {num} Category ID : {cd.CategoryId}  Category Name : {cd.CategoryName} ");
                num++;           
             }
        }
    }
}
