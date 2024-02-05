using Appliaction.Contract;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Services
{
    public class UserService : IUserService

    {
        

        private readonly IUserRepository USerRepository;
       

        public UserService(IUserRepository _IUserRepository)
        {

            USerRepository = _IUserRepository;
           
        }

        public void AddUser(User user)
        {
            USerRepository.add(user);
            USerRepository.AddtoUserRole(user);

            // make an user ROle 
                
        }

        public void DeleteUser(int id)
        {
           USerRepository.delete(id);
        }

        public IQueryable<User> GetUser()
        {
          return USerRepository.getAll() ;
        }

        public User? GetUserbyID(int id)
        {
           return USerRepository.getByID(id);
        }

        public User UpdateUser(User user)
        {
            return USerRepository.update(user);
        }

        public string GetUserRole(User user)
        {
            return  USerRepository.GetUserRole(user).ToLower();
        }
        public User GetUserByUsername(string username)
        {
            return USerRepository.GetUserByUsername(username);
        }

        public bool IsUsernameAvailable(string username)
        {
            return USerRepository.IsUsernameAvailable(username);
        }

       
    }

}
