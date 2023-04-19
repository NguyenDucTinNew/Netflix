using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace websitequanlutours.Models
{
    public class TinhTrangTour
    {
        [Key]
        public int MaTinhTrangTour { get; set; }
        public string TinhTrangTour1 { get;set; }
    }
}