using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Security;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Web.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        #region Register

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            if (_userService.IsExistEmail(register.Email))
            {
                ModelState.AddModelError("Email", "The Email Is Not Valid");

                return View(register);
            }

            if (_userService.IsExistUserName(register.UserName))
            {
                ModelState.AddModelError("UserName", "The UserName Is Not Valid ");
                return View(register);
            }

            var user = new User()
            {
                Email = register.Email,
                Password = PasswordHelper.EncodePasswordMd5(register.Password),
                UserName = register.UserName
            };

            _userService.RegisterUser(user);
            return View("SuccessRegister", register);
        }
        #endregion

        #region Login

        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            if (!_userService.IsExistUser(login.Email, login.Password))
            {
                ModelState.AddModelError("Email", "The User Not Found");
                return View(login);
            }

            return View();
        }
        #endregion
    }
}
