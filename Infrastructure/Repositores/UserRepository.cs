using Appliaction.Contract;
using Context;
using Infrastructure.Repositores;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositores
{



    public class UserRepository : Repository<User, int>, IUserRepository
    {   
        private readonly _Context Context;
        public UserRepository(_Context _context) : base(_context)
        {
            Context = _context;
        }
        public User GetUserByUsername(string username)
        {

           
                return Context.Users.FirstOrDefault(u => u.UserName == username);
           
        }

        public bool IsUsernameAvailable(string username)
        {

          
                return Context.Users.Any(u => u.UserName == username);
            
        }

        public int AddtoUserRole(User _user)
        {
           var roleobj = Context.Roles.FirstOrDefault(x => x.Name == "User");
           Context.UserRoles.Add(new UserRole() { Role= roleobj, User =_user});
            return Context.SaveChanges();
        }

        public string GetUserRole(User user) 
        {
        
          var roleID =  Context.UserRoles.FirstOrDefault(x=>x.UserID == user.Id).RoleID;

          return  Context.Roles.FirstOrDefault(x => x.ID == roleID).Name;
        }


    }

}
