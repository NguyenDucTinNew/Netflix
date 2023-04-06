using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace websitequanlutours.Models
{
    public class DiaDiemHotNuocNgoai
    {
        [Key]
        public int MaDiaDiemHotNuocNgoai { get; set; }
        [Display(Name = "Địa điểm hot nước ngoài")]
        [Required]
        public string DiaDiemHotNuocNgoai1 { get; set; }


    }
}