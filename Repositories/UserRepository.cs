using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAuth.Models;

namespace ApiAuth.Repositories
{
    public class UserRepository
    {
        public static User Get(string username, string password){
            var users = new List<User>();
            users.Add(new User {Id = 1, UserName = "Batman", Role = "Manager", Password = "Batman" });
            users.Add(new User{ Id=2, UserName="Robin", Role="Enployee", Password= "Robin" });
            return users 
                    .FirstOrDefault(x => x.UserName == username
                    && x.Password == password);
        }
        
    }
}