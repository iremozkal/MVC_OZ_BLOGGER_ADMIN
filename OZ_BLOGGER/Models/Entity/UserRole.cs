using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OZ_BLOGGER.Models.Entity
{
    public class UserRole : BaseClass
    {
        public int UserRoleId { get; set; }
        public string UserRoleName { get; set; }

        // ONE UserRole has MANY User
        public List<User> UsersOfRole { get; set; }
    }
}