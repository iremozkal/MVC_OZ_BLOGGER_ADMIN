using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OZ_BLOGGER.Models.Entity
{
    public class Training : BaseClass
    {
        public int TrainingId { get; set; }
        public string SchoolName { get; set; }
        public string SchoolDescription { get; set; }
        public string Department { get; set; }
        public DateTime GraduatedAt { get; set; }

        // ONE Training has MANY UserDetail
        public List<UserDetail> UsersOfTraining { get; set; }
    }
}