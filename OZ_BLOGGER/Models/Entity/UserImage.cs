using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OZ_BLOGGER.Models.Entity
{
    public class UserImage : BaseClass
    {
        // It doesn't have its own id, uses user's id. Set PrimaryKey with Mapping.
        public int UserId { get; set; }
        public string AlternativeTitle { get; set; }
        public string ImagePath { get; set; }

        // ONE UserImage has ONE User
        public User UserOfImage { get; set; }
    }
}