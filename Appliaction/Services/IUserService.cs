using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Services
{
    public interface IUserService
    {

        void AddUser(User user);
        User? GetUserbyID(int id);
        IQueryable<User> GetUser();
        public User UpdateUser(User user);
        public void DeleteUser(int id);
        public string GetUserRole(User user);
        //new function for the user
        bool IsUsernameAvailable(string username);
        User GetUserByUsername(string username);
       

        
    }
}
