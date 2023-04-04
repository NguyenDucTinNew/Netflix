using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace websitequanlutours.Models
{
    public class TourTheoChuDe
    {
        [Key]
        public int MaChuDe { get; set; }
        [Display(Name = "Chủ đề ")]
        [Required]
        public string TourTheoChuDe1 { get; set; }
      

    }
}