using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace websitequanlutours.Models
{
    public class Tour
    {

        [Key]
        public int TourId { get; set; }
        
        
        [Display(Name = "Tên tour")]
        [Required(ErrorMessage = "Vui lòng không để trống")]
      
        public string TenTour { get; set; } = null;

        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        [Required(ErrorMessage = "Vui lòng không để trống")]
        public Nullable<System.DateTime> ThoiGianTour { get; set; } = null;
        [Display(Name = "Giá")]
        [Required(ErrorMessage = "Vui lòng không để trống")]
        public Nullable<decimal> Gia { get; set; } = null;
        [Display(Name = "Chương trình tour")]
        [Required(ErrorMessage = "Vui lòng không để trống")]

        public string ChuongTrinhTour { get; set; } = null;
        [Required(ErrorMessage = "Vui lòng không để trống")]
        [Display(Name = "Image File")]
        public string ImageFile { get; set; } = null;
        [Display(Name = "Loại tour")]
  /*      [Required(ErrorMessage = "Vui lòng không để trống")]*/
       
        public string LoaiTour { get; set; } = null;
        [Display(Name = "Chủ đề ")]
      /*  [Required(ErrorMessage = "Vui lòng không để trống")]*/
        
        public string ChuDe { get; set; } = null;
        [Display(Name = "Tour nước ngoài")]
        /*      [Required(ErrorMessage = "Vui lòng không để trống")]*/
        
        public string TourNuocNgoai { get; set; } = null;
        [Display(Name = "Tour trong nước")]
     /*   [Required(ErrorMessage = "Vui lòng không để trống")]*/
        
        public string TourTrongNuoc { get; set; } = null;
        [Display(Name = "Địa điểm hot nước ngoài")]
/*        [Required(ErrorMessage = "Vui lòng không để trống")]
*/        
        public string DiaDiemHotNuocNgoai { get; set; } = null;
        [Display(Name = "Địa điểm hot trong nước")]
/*        [Required(ErrorMessage = "Vui lòng không để trống")]
*/       
        public string DiaDiemHotTrongNuoc { get; set; } = null;
        /*   public int MaDon { get; set; }*/



    }
}