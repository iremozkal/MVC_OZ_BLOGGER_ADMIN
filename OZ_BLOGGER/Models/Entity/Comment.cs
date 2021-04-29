using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OZ_BLOGGER.Models.Entity
{
    public class Comment : BaseClass
    {
        public int CommentId { get; set; }
        public string CommentContext { get; set; }

        // ONE Comment has ONE Blog
        public int BlogId { get; set; }
        public Blog BlogOfComment { get; set; }

        // ONE Comment has ONE User
        public int UserId { get; set; }
        public User UserOfComment { get; set; }
    }
}