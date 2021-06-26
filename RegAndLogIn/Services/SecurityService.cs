using RegAndLogIn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegAndLogIn.Services
{
    public class SecurityService
    {
       // List<UserModel> knownUsers = new List<UserModel>();
        UsersDAO usersDAO = new UsersDAO();

        public SecurityService()
        {
        
        }


        public bool isValid(UserModel user)
        {
            return usersDAO.FindUserByNameAndPassword(user);
           // return knownUsers.Any(x => x.UserName == user.UserName && x.Password == user.Password);
        }
    }
}
