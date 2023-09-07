using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneCsharp
{
    class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public Products(int pid, string pname, int pqnty,int price)
        {
            this.ProductId = pid;
            this.ProductName = pname;
            this.Quantity = pqnty;
            this.Price = price;
        }
    }
}
