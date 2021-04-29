using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OZ_BLOGGER.Models.Entity
{
    public class Tag : BaseClass
    {
        public int TagId { get; set; }
        public string TagName { get; set; }

        // ONE Tag has MANY Blogs
        public List<Blog> BlogsOfTag { get; set; }
    }
}