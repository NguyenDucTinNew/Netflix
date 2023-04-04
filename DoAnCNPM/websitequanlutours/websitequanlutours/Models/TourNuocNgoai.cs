using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebsiteQuanLyTours.Models;

namespace websitequanlutours.Models
{
    public class TourNuocNgoai
    {
        [Key]
        public long MaTourNuocNgoai { get; set; }
        [Display(Name = "Tour nước ngoài")]
        [Required(ErrorMessage = "Vui lòng không để trống Tour nước ngoài")]
        public string TourNuocNgoai1 { get; set; }
    
    }
}