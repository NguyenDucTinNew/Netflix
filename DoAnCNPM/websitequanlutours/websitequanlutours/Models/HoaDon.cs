using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using websitequanlutours.Identity;

namespace websitequanlutours.Models
{
    public class HoaDon
    {
        [Key]
        public int MaHoaDon { get; set; }
        public string UserId { get; set; }
        public DateTime NgayDatTour { get; set; }
        public decimal TongGia { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser User { get; set; }
    }
}