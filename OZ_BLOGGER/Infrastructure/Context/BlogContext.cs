using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using OZ_BLOGGER.Models.Entity;
using OZ_BLOGGER.Infrastructure.Mapping;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OZ_BLOGGER.Infrastructure.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext()
            : base("Server=.; Database=BloggerDB; Integrated Security=SSPI")
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<UserDetail> UserDetail { get; set; }
        public DbSet<UserImage> UserImage { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Seminar> Seminar { get; set; }
        public DbSet<Certification> Certification { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<BlogImage> BlogImage { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<Comment> Comment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserDetailMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new UserImageMapping());
            modelBuilder.Configurations.Add(new BlogMapping());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

    }
}