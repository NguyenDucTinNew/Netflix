using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebsiteQuanLyTours.Models;

namespace websitequanlutours.Models
{
    public class TourTrongNuoc
    {
        [Key]
        public long MaTourTrongNuoc { get; set; }
        [Display(Name = "Tour trong nước")]
        [Required(ErrorMessage = "Vui lòng không để trống Tour trong nước")]
        public string TourTrongNuoc1 { get; set; }
       

    }
}