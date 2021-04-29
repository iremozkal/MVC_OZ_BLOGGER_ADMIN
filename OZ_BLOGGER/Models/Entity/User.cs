using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OZ_BLOGGER.Models.Entity
{
    public class User : BaseClass
    {
        public int UserId { get; set; }
        public string UserNameSurname { get; set; }
        public string Username { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }

        // ONE User has ONE UserRole
        public int UserRoleId { get; set; }
        public UserRole RoleOfUser { get; set; }

        // ONE User has MANY Comments 
        public List<Comment> CommentsOfUser { get; set; }

        // ONE User has ONE UserImage
        public int UserImageId { get; set; }
        public UserImage ImageOfUser { get; set; }

        // ONE User has ONE UserDetail
        public UserDetail DetailOfUser { get; set; }
    }
}