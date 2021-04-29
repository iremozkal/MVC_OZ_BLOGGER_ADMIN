using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OZ_BLOGGER.Models.Entity
{
    public class BlogImage : BaseClass
    {
        public int BlogImageId { get; set; }
        public string BlogImageAlternative { get; set; }
        public string BlogImagePath { get; set; }

        // ONE Image has MANY Blogs
        public List<Blog> BlogsOfImage { get; set; }
    }
}