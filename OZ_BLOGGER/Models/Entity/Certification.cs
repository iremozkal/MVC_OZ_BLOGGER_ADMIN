using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OZ_BLOGGER.Models.Entity
{
    public class Certification : BaseClass
    {
        public int CertificationId { get; set; }
        public string CertificationTitle { get; set; }
        public string CertificationDescription { get; set; }
        public string CertificationCompany { get; set; }
        public DateTime CertificationDate { get; set; }

        // ONE Certification has MANY UserDetail 
        public List<UserDetail> UsersOfCertification { get; set; }
    }
}