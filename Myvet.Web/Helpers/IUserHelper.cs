﻿using Microsoft.AspNetCore.Identity;
using Myvet.Web.Data.Entities;
using Myvet.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myvet.Web.Helpers
{
    namespace Myvet.Web.Helpers
    {
        public interface IUserHelper
        {
            Task<User> GetUserByEmailAsync(string email);

            Task<IdentityResult> AddUserAsync(User user, string password);

            Task CheckRoleAsync(string roleName);

            Task AddUserToRoleAsync(User user, string roleName);

            Task<bool> IsUserInRoleAsync(User user, string roleName);
            Task<SignInResult> LoginAsync(LoginViewModel model);

            Task LogoutAsync();

        }
    }

}
