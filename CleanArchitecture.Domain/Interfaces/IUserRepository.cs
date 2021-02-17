using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void Save();
        bool IsexistUserName(string userName);
        bool IsExistEmail(string email);
        bool IsExistUser(string email, string password);
    }
}
