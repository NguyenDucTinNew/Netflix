using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using websitequanlutours.Models;

using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity.EntityFramework;
using websitequanlutours.Identity;

namespace websitequanlutours.Models
{
    public class quanlytoursDBContext : IdentityDbContext<AppUser>
    {
        public quanlytoursDBContext() : base("MyConnectionString") { }
        public DbSet<Tour> tours { get; set; }
       
       

        
        
       


       public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<CartItem> CartItems { get; set; }



       /* protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AppUser>()
                .HasOptional(u => u.Cart)
                .WithOptionalPrincipal(c => c.User);
        }*/
    }
}