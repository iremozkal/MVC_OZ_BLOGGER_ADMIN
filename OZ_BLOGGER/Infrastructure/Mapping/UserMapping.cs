using OZ_BLOGGER.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace OZ_BLOGGER.Infrastructure.Mapping
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            // 1 User has 1 UserRole, 1 UserRole has M User (1-M)
            HasRequired(x => x.RoleOfUser).WithMany(x => x.UsersOfRole).HasForeignKey(x => x.UserRoleId);

            // 1 User has M Comment, 1 Comment has 1 User (M-1)
            HasMany(x => x.CommentsOfUser).WithRequired(x => x.UserOfComment).HasForeignKey(x => x.UserId);

            // 1 User has 1 UserImage, 1 UserImage has 1 User. (1-1)
            // When creating a user, it is not necessary to create a user picture, it is necessary to create a user to create a user picture.
            HasOptional(x => x.ImageOfUser).WithRequired(x => x.UserOfImage);

            // If we wanted the UserImage to be required:
            // HasRequired(x => x.ImageOfUser).WithRequiredDependent(x => x.UserOfImage);
        }
    }
}