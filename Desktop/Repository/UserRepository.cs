using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Entities;
using Entities.Models;

namespace Desktop.Repository
{
    public class UserRepository
    {
        public static readonly List<UserModel> Users = new List<UserModel>
        {
            new UserModel("Denis", "deniska-frolkov@mail.ru", "12345678"),
            new UserModel("Liz", "lizaliza@mail.ru", "123454321")
        };
        public static UserModel RegistrationUser(UserModel user)
        {
            foreach (var item in Users)
            {
                if( user.email == item.email)
                {
                    return null;
                } 
            }
            Users.Add(user);
            return user;
        }

        public static UserModel LoginUser(UserModel user) =>
            Users.FirstOrDefault(item => item.email == user.email && item.password == user.password);
    }
}