using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private DataBaseContext _context;
        public UserRepository(DataBaseContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
        }

        public bool IsExistEmail(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }

        public bool IsExistUser(string email, string password)
        {
            return _context.Users.Any(u => u.Email == email && u.Password == password);
        }

        public bool IsexistUserName(string userName)
        {
            return _context.Users.Any(u => u.UserName == userName);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
