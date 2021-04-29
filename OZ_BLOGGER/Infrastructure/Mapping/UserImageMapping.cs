using OZ_BLOGGER.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace OZ_BLOGGER.Infrastructure.Mapping
{
    public class UserImageMapping : EntityTypeConfiguration<UserImage>
    {
        public UserImageMapping()
        {
            HasKey(x => x.UserId);
        }
    }
}