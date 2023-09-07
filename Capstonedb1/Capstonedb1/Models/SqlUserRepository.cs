using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstonedb1.Models
{
    public class SqlUserRepository 
    {
        /*private AppDbContext _registration;
        public SqlUserRepository(AppDbContext context)
        {
            _registration = context;
        }
        public bool AddUser(Register User)
        {
            Register isDuplicate = _registration.Registrations.FirstOrDefault(each => each.Email.ToLower() == User.Email.ToLower());
            if (isDuplicate == null)
            {
                _registration.Add(User);
                _registration.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
}
