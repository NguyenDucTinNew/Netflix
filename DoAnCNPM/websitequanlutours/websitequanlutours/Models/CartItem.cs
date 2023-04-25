using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using websitequanlutours.ViewModel;
using websitequanlutours.Identity;

namespace websitequanlutours.Models
{
    public class CartItem
    {
        [Key]
        public int MaGioTour { get; set; }
        public int MaHoaDon { get; set; }
        public int TourId { get; set; }
        
        public int Quantity { get; set; }
        public virtual Tour Tour { get; set; }
        public virtual HoaDon HoaDon { get; set; }
    }
}


