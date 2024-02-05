using Appliaction.Services;
using Context;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Contract
{
    public interface IUserRepository : IG_Repo<User,int>
    {

        public User GetUserByUsername(string username);
        /* {

             using (var dbContext = new _Context())
             {
                 return dbContext.Users.FirstOrDefault(u => u.UserName == username);
             }
         }*/

        public bool IsUsernameAvailable(string username);
        /* {

             using (var dbContext = new _Context())
             {
                 return !dbContext.Users.Any(u => u.UserName == username);
             }
         }*/
        public int AddtoUserRole(User _user);

        public string GetUserRole(User user);
        


    }


}


