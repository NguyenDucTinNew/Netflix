using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace websitequanlutours.Models
{
    public class DiaDiemHotTrongNuoc
    {
        [Key]
        public int MaDiaDiemHotTrongNuoc { get; set; }
        [Display(Name = "Địa điểm hot trong nước")]
        [Required]
        public string DiaDiemHotTrongNuoc1 { get; set; }


    }
}