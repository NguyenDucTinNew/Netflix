using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using websitequanlutours.Models;

namespace websitequanlutours.Models
{
    public class LoaiTour
    {
        [Key]
        public int MaLoaiTour { get; set; }
        [Display(Name = "Loại tour")]
        [Required]
        public string LoaiTours { get; set; }
      
    }
}