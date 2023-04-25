using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using websitequanlutours.Models;
using websitequanlutours.ViewModel;

namespace websitequanlutours.Identity
{
    public class AppUser : IdentityUser
    {
        
        
        public DateTime? NgaySinh { get; set; }

        public string DiaChi { get; set; }

        public string Mobile { get; set; }

        public string ImageFile { get; set; }
        public string UserId { get; set; }
        

        
    }

  
}

   