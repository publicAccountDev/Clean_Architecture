using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IUserService
    {
        int RegisterUser(User user);
        bool IsExistEmail(string email);
        bool IsExistUserName(string userName);
    }
}
