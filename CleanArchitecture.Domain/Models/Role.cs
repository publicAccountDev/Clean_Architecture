using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Domain.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleTitle { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}
