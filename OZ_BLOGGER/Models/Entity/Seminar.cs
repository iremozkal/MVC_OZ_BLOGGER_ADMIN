using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OZ_BLOGGER.Models.Entity
{
    public class Seminar : BaseClass
    {
        public int SeminarId { get; set; }
        public string SeminarTitle { get; set; }
        public string SeminarDEscription { get; set; }
        public DateTime SeminarDate { get; set; }
        public string SeminarPlace { get; set; }

        // ONE Seminar has ONE UserDetail
        public int UserId { get; set; }
        public UserDetail UserOfSeminar { get; set; }
    }
}