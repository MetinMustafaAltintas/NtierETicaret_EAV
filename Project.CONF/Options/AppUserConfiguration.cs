using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class AppUserConfiguration:BaseConfiguration<AppUser>
    {
        public AppUserConfiguration()
        {
            HasOptional(x => x.AppUserProfile).WithRequired(x => x.AppUser);
        }
    }
}
