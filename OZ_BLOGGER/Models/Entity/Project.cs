using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OZ_BLOGGER.Models.Entity
{
    public class Project : BaseClass
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public string ProjectLink { get; set; }

        // ONE Project has MANY UserDEtail
        public List<UserDetail> UserDetailsOfProject { get; set; }
    }
}