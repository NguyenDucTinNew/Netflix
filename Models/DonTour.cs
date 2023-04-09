using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using websitequanlutours.ViewModel;

namespace websitequanlutours.Models
{
    public class DonTour
    {
        [Key]
        public int MaDT { get; set; }
        public Nullable<int> DaThanhToan { get; set; }
        public Nullable<int> TinhTrangTour { get; set; }
        public Nullable<System.DateTime> NgayKhoiHanh { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }

      

      

    }
}