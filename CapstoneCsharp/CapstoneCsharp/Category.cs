using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneCsharp
{
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        
       public Category(int id,string name)
        {
            this.CategoryId = id;
            this.CategoryName = name;
            

        }

        /*public static implicit operator Category(string v)
        {
            throw new NotImplementedException();
        }*/
    }
}
