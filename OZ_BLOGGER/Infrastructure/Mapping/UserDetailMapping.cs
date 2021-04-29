using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OZ_BLOGGER.Models.Entity;
using System.Data.Entity.ModelConfiguration;

namespace OZ_BLOGGER.Infrastructure.Mapping
{
    public class UserDetailMapping : EntityTypeConfiguration<UserDetail>
    {
        public UserDetailMapping()
        {
            // Primary Key setting
            HasKey(x => x.UserId);

            // 1 UserDetail has 1 User, 1 User has 1 UserDetail (1-1)
            HasRequired(x => x.UserOfDetail).WithOptional(x => x.DetailOfUser);

            // 1 UserDetail has M IsDeneyim, 1 Experience has 1 UserDetail (M-1)
            HasMany(x => x.ExperiencesOfUser).WithRequired(x => x.UserDetailOfExperience).HasForeignKey(x => x.UserId);

            // 1 UserDetail has M Project, 1 Project has M UserDetail (M-M)
            HasMany(x => x.ProjectsOfUser).WithMany(x => x.UserDetailsOfProject);

            // 1 UserDetail has M Training, 1 Training has M UserDetail (M-M)
            HasMany(x => x.TrainingsOfUser).WithMany(x => x.UsersOfTraining);

            // 1 UserDetail has M Seminar, 1 Seminar has 1 UserDetail (M-1)
            HasMany(x => x.SeminarsOfUser).WithRequired(x => x.UserOfSeminar).HasForeignKey(x => x.UserId);

            // 1 UserDetail has M Certification, 1 Certification has M UserDetail (M-M)
            HasMany(x => x.CertificationsOfUser).WithMany(x => x.UsersOfCertification);

            // 1 UserDetail has M Course, 1 Course has M UserDetail (M-M)
            HasMany(x => x.CoursesOfUser).WithMany(x => x.UsersOfCourse);

            // 1 UserDetail has M Blog, 1 Blog has 1 UserDetail (M-1)
            HasMany(x => x.BlogsOfUser).WithRequired(x => x.UserOfBlog).HasForeignKey(x => x.UserId);

            // 1 UserDetail has M SocialMedia, 1 SocialMedia has M UserDetail (M-M)
            HasMany(x => x.SocialMediasOfUser).WithMany(x => x.UserOfSocialMedia);
        }
    }
}