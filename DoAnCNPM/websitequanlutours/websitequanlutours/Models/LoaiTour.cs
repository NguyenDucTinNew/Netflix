using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebsiteQuanLyTours.Models;

namespace WebsiteQuanLyTours.Models
{
    public class LoaiTour
    {
        [Key]
        public long MaLoaiTour { get; set; }
        [Display(Name = "Loại tour")]
        [Required(ErrorMessage = "Vui lòng không để trống Loại tour")]
        public string LoaiTours { get; set; }
      
    }
}