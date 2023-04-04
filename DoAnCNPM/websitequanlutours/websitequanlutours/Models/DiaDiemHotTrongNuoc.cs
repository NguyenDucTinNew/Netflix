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
        public long MaDiaDiemHotTrongNuoc { get; set; }
        [Display(Name = "Địa điểm hot trong nước")]
        [Required(ErrorMessage = "Vui lòng không để trống Địa điểm hot trong nước")]
        public string DiaDiemHotTrongNuoc1 { get; set; }


    }
}