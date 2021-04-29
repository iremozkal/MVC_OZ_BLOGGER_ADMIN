using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OZ_BLOGGER.Models.Entity
{
    public class UserDetail : BaseClass
    {
        // It doesn't have its own id, uses user's id. Set PrimaryKey with Mapping.
        public int UserId { get; set; }
        public DateTime BirthDate { get; set; }
        public string Description { get; set; }

        // ONE Detail has ONE User
        public User UserOfDetail { get; set; }

        // ONE UserDetail has MANY Experiences
        public List<Experience> ExperiencesOfUser { get; set; }

        // ONE UserDetail has MANY Project
        public List<Project> ProjectsOfUser { get; set; }

        // ONE UserDetail has MANY Trainings
        public List<Training> TrainingsOfUser { get; set; }

        // ONE UserDetail has MANY Seminar
        public List<Seminar> SeminarsOfUser { get; set; }

        // ONE UserDetail has MANY Certifications
        public List<Certification> CertificationsOfUser { get; set; }

        // ONE UserDetail has MANY Courses
        public List<Course> CoursesOfUser { get; set; }

        // ONE UserDetail has MANY Blogs
        public List<Blog> BlogsOfUser { get; set; }

        // ONE UserDetail has MANY SocialMedias
        public List<SocialMedia> SocialMediasOfUser { get; set; }
    }
}