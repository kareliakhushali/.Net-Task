using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16_03_2023
{
    class Product : System.IComparable
    {
       
            public int Id { get; set; }
            public string Name { get; set; }
            public int Qty { get; set; }
            public int Rate { get; set; }
            public string Category { get; set; }     
            #region System.IComparable members      
            public int CompareTo(object obj)
        {
            Product p = obj as Product;
            return this.Id.CompareTo(p.Id);
        }
        #endregion
    }
}

