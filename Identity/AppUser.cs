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
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaUser { get; set; } // Kiểu dữ liệu có thể khác tùy theo thiết kế của bạn
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get; set; }

        public string Mobile { get; set; }

        public string ImageFile { get; set; }

        public int? MaHoaDon { get; set; }

       public virtual HoaDon HoaDon { get; set; }

    }
  
}

   