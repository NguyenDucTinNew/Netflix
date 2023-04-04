using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace websitequanlutours.Models
{
    public class ChiTietDonTour
    {
        [Key]
        public int MaDon { get; set; }

        public int MaTour { get; set; }
        public int SoLuong { get; set; }
        public Nullable<decimal> DonGia { get; set; }



        public virtual Tour Tour { get; set; }


    }
}