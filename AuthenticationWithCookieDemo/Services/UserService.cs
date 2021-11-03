using AuthenticationWithCookieDemo.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationWithCookieDemo.Services
{
    public interface IUserService
    {
        UserModel Authenticate(LoginModel model);
    }

    public class UserService : IUserService 
    {
        private static readonly UserModel _user = new()
        {
            Name = "Lars",
            Email = "lany@ucn.dk",
            Role = "Teacher"
        };

        public UserModel Authenticate(LoginModel model)
        {
            // TODO: this should be a database lookup for the user, but for now we use a user fake
            if (model.Username == "lars" && model.Password == "1337lars")
            {
                return _user;
            }
            return null;
        }       
    }
}
