﻿using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public int AddUser(User user)
        {
            _userRepository.AddUser(user);
            _userRepository.Save();
            return user.UserId;
        }

        public bool IsExistEmail(string email)
        {
            return _userRepository.IsExistEmail(email);
        }

        public bool IsExistUserName(string userName)
        {
            return _userRepository.IsexistUserName(userName);
        }
    }
}
