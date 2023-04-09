using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace websitequanlutours.Models
{
    public class TourNuocNgoai
    {
        [Key]
        public int MaTourNuocNgoai { get; set; }
        [Display(Name = "Tour nước ngoài")]
        [Required]
        public string TourNuocNgoai1 { get; set; }
    
    }
}