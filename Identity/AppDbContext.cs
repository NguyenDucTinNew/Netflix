using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using websitequanlutours.Models;

namespace websitequanlutours.Identity
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {



     
      
        

        public AppDbContext() : base("MyConnectionString") { }


        
    }
}