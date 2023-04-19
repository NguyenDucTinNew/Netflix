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
        public int IdItem { get; set; }
        public int MaTour { get; set; }
        public int SoLuong { get; set; }
        public decimal? DonGia { get; set; }

        public virtual Tour Tour { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}


