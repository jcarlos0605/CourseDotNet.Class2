﻿using System.Collections.Generic;
using System.Linq;
using CourseDotNet.Class2.Roles.Dto;
using CourseDotNet.Class2.Users.Dto;

namespace CourseDotNet.Class2.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.Roles != null && User.Roles.Any(r => r == role.Name);
        }
    }
}