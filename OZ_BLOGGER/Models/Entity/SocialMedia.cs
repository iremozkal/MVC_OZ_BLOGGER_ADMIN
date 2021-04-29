using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OZ_BLOGGER.Models.Entity
{
    public class SocialMedia : BaseClass
    {
        public int SocialMediaId { get; set; }
        public string IconPath { get; set; }
        public string Link { get; set; }

        // One SocialMedia has MANY UserDetail
        public List<UserDetail> UserOfSocialMedia { get; set; }
    }
}