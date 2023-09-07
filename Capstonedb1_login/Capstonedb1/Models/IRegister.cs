using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstonedb1.Models
{
   public interface IRegister
    {
        public Register GetUserById(int id);
        public Register GetUserByUserName(string Username);


        public bool AddUser(Register User);
        public bool VerifyUser(Register user);
        Register GetUserByEmail(string email);
    }
}
