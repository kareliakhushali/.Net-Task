using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneCsharp
{
    public interface IAdmin
    {
        /*void ManageCategory();
        void ManageSubcategory();
        void ManageProduct();*/
        void Add(IAdmin i);
        void Update();
        void Delete(IAdmin i);
    }
}
