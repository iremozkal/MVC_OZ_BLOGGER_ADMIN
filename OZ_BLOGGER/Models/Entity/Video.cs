using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OZ_BLOGGER.Models.Entity
{
    public class Video : BaseClass
    {
        public int VideoId { get; set; }
        public string VideoTitle { get; set; }
        public string VideoLink { get; set; }
    }
}