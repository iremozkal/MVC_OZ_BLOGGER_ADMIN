using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OZ_BLOGGER.Models.Entity
{
    public class Blog : BaseClass
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }

        // ONE Blog has ONE UserDetail
        public int UserId { get; set; }
        public UserDetail UserOfBlog { get; set; }

        // ONE Blog has ONE Category
        public int CategoryId { get; set; }
        public Category CategoryOfBlog { get; set; }

        // ONE Blog has MANY Yorum
        public List<Comment> CommentsOfBlog { get; set; }

        // ONE Blog has MANY MakaleResim
        public List<BlogImage> ImagesOfBlog { get; set; }

        // ONE Blog has MANY Etiket
        public List<Tag> TagsOfBlog { get; set; }
    }
}