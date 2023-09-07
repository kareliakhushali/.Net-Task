using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneCsharp
{
    class SubcategoryData
    {
        Subcategory sd;
        public  List<Subcategory> subcategoryList = new List<Subcategory>();
        public void SubCategoryDataManage()
        {
            int choice;
            do
            {
                Console.WriteLine("\n===========Perform Operations=========");
                Console.WriteLine("\n1. Add SubCategory");
                Console.WriteLine("2. Update SubCategory");
                Console.WriteLine("3. Delete SubCategory");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:


                        AddSubCategory();

                        Display();
                        break;
                    case 2:
                        UpdateSubcategory();
                        /*  Console.WriteLine("Enter the old Subcategory name: ");
                          string oldCategory = Console.ReadLine();
                          Console.WriteLine("Enter the new Subcategory name: ");
                          string newCategory = Console.ReadLine();
                          UpdateSubcategory(oldSubCategory, newSubCategory);
                          Display();*/
                        break;
                    case 3:

                        Console.WriteLine("Enter index which you want to delete");
                        int index_id = Convert.ToInt32(Console.ReadLine());
                        DeleteSubcategory(index_id - 1);
                        Display();
                        break;
                }
            }

            while (choice != 3);

        }
        public void AddSubCategory()
        {

            Console.WriteLine("Enter SubCategory ID :");
          //  int temp_sid = Convert.ToInt32(Console.ReadLine());
            int temp_sid;

            while (!int.TryParse(Console.ReadLine(), out temp_sid))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer value for the Subcategory ID:");
            }
            Console.WriteLine("Enter SubCategory Name:");
            string temp_sname = Console.ReadLine();
            bool nameExists = false;
            foreach (Subcategory existingCategory in subcategoryList)
            {
                if (existingCategory.SubCategoryName == temp_sname)
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
                Subcategory sc = new Subcategory(temp_sid, temp_sname);
                subcategoryList.Add(sc);
                Console.WriteLine("Category added successfully....:");

            }

            // Subcategory sc = new Subcategory(temp_sid, temp_sname);
            //subcategoryList.Add(sc);
            //Console.WriteLine("Category added successfully....:");
            //   categoryList.Add(add_category);
            //subcategory.Add((SubcategoryData)i);

        }
        public void UpdateSubcategory()
        {
            Display();
            Console.WriteLine("Enter index which you want to update : ");
            int index = Convert.ToInt32(Console.ReadLine());
            //  UpdateCategory(index);
            Subcategory sc = subcategoryList[index - 1];
            string updated_name;


            Console.WriteLine($" Subcategory ID : {sc.SubCategoryId }  Subcategory Name : {sc.SubCategoryName}  ");
            Console.WriteLine("Do You want to update Subcategory name ? Yes/No ");

            string temp = Console.ReadLine();
            if (temp.ToLower().Equals("yes"))
            {
                Console.WriteLine("Enter your updated name");
                updated_name = Console.ReadLine();
            }
            else
            {
                updated_name = sc.SubCategoryName;

            }
            sc.SubCategoryName = updated_name;
            subcategoryList[index - 1] = sc;
            Console.WriteLine("============Updated data==========");
            Display();
            /* int index = subcategoryList.IndexOf(oldSubCategory);
             if (index != -1)
             {
                 subcategoryList[index] = newSubCategory;
             }*/

        }
        public void DeleteSubcategory(int delete_subcategory)
        {
            // subcategory.Remove((SubcategoryData)i);
            subcategoryList.RemoveAt(delete_subcategory);
            Console.WriteLine("Deleted....:");
        }
        public void Display()
        {
            int num = 1;

            foreach (Subcategory sd in subcategoryList)
            {
                Console.WriteLine($"Index = {num} SubCategory ID : {sd.SubCategoryId}  SubCategory Name : {sd.SubCategoryName} ");
                num++;
            }
        }
    }
}
