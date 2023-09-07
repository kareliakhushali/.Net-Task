using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneCsharp
{
    class Subcategory
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
      

        public Subcategory(int sid, string sname)
        {
            this.SubCategoryId = sid;
            this.SubCategoryName = sname;


        }
    }
}
