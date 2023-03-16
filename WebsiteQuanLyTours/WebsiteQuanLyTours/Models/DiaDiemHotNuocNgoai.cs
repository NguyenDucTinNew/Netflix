using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebsiteQuanLyTours.Models;

namespace WebsiteQuanLyTours.Models
{
    public class DiaDiemHotNuocNgoai
    {

        [Key]
        public long MaDiaDiemHotNuocNgoai { get; set; }
        [Display(Name = "Địa điểm hot nước ngoài")]
        [Required(ErrorMessage = "Vui lòng không để trống Địa điểm hot nước ngoài")]
        public string DiaDiemHotNuocNgoai1 { get; set; }

       
    }
}