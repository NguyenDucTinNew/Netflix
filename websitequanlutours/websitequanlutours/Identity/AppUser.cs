using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace websitequanlutours.Identity
{
    public class AppUser : IdentityUser
    {
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get; set; }

        public string Mobile { get; set; }
    }
}