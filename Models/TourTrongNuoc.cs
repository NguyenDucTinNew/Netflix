using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace websitequanlutours.Models
{
    public class TourTrongNuoc
    {
        [Key]
        public int MaTourTrongNuoc { get; set; }
        [Display(Name = "Tour trong nước")]
        [Required]
        public string TourTrongNuoc1 { get; set; }
       

    }
}