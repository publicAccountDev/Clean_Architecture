using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Application.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [MaxLength(200)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(200)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(200)]
        public string Password { get; set; }
        [Required]
        [MaxLength(200)]
        [Compare("Password")]
        public string RePassword { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [MaxLength(200)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(200)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool ReMemberMe { get; set; }
    }
}
