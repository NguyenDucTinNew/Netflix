using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace websitequanlutours.Models
{
    public class HoaDon
    {
        [Key]
        public int MaHoaDon { get; set; }

        public int MaTinhTrangTour { get; set; }
        public int MaUser { get; set; }

        public int IdItem { get; set; }




        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual TinhTrangTour TinhTrangTour { get;set; }

    }
}