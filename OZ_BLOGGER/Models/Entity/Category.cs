using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OZ_BLOGGER.Models.Entity
{
    public class Category : BaseClass
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        // ONE Category has MANY Blogs
        public virtual List<Blog> BlogsOfCategory { get; set; }
    }
}