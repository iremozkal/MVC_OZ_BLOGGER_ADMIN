using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OZ_BLOGGER.Models.Entity
{
    public class Experience : BaseClass
    {
        public int ExperienceId { get; set; }
        public string ExperienceName { get; set; }
        public string ExperienceDescription { get; set; }
        public DateTime ExperienceStartDate { get; set; }
        public DateTime ExperienceEndDate { get; set; }
        public string JobTitle { get; set; }

        // ONE Experience has ONE UserDetail.
        public int UserId { get; set; }
        public UserDetail UserDetailOfExperience { get; set; }
    }
}