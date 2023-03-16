using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebsiteQuanLyTours.Models;

namespace WebsiteQuanLyTours.Models
{
    public class TourTheoChuDe
    {
        [Key]
        public long MaChuDe { get; set; }
        [Display(Name = "Chủ đề ")]
        [Required(ErrorMessage = "Vui lòng không để trống Chủ đề")]
        public string TourTheoChuDe1 { get; set; }
      

    }
}