using OZ_BLOGGER.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace OZ_BLOGGER.Infrastructure.Mapping
{
    public class BlogMapping : EntityTypeConfiguration<Blog>
    {
        public BlogMapping()
        {
            // 1 Blog has 1 Category, 1 Category has M Blog (1-M)
            HasRequired(x => x.CategoryOfBlog).WithMany(x => x.BlogsOfCategory).HasForeignKey(x => x.CategoryId);

            // 1 Blog has M Comment, 1 Comment has 1 Blog (M-1)
            HasMany(x => x.CommentsOfBlog).WithRequired(x => x.BlogOfComment).HasForeignKey(x => x.BlogId);

            // 1 Blog has Many Image, 1 Image has M Blog (M-M)
            HasMany(x => x.ImagesOfBlog).WithMany(x => x.BlogsOfImage);

            // 1 Blog has M Tag, 1 Tag has M Blog (M-M)
            HasMany(x => x.TagsOfBlog).WithMany(x => x.BlogsOfTag);
        }
    }
}