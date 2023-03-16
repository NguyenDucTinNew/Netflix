using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebsiteQuanLyTours.Models;

namespace WebsiteQuanLyTours.Models
{
    public class Tour
    {
        [Key]
        public long MaTour { get; set; }
        [Display(Name ="Tên tour")]
        [Required(ErrorMessage= "Vui lòng không để trống Tên tour")]
        public string TenTour { get; set; }
        [Display(Name = "Thời gian tour")]
        [Required(ErrorMessage = "Vui lòng không để trống Thời gian tour")]
        public Nullable<System.DateTime> ThoiGianTour { get; set; }
        [Display(Name = "Giá")]
        [Required(ErrorMessage = "Vui lòng không để trống Giá")]
        public Nullable<decimal> Gia { get; set; }
        [Display(Name = "Chương trình tour")]
        [Required(ErrorMessage = "Vui lòng không để trống Chương trình tour")]
        public string ChuongTrinhTour { get; set; }
        [Display(Name = "Loại tour")]
        [Required(ErrorMessage = "Vui lòng không để trống Loại tour")]
        public Nullable<long> MaLoaiTour { get; set; }
        [Display(Name = "Chủ đề ")]
        [Required(ErrorMessage = "Vui lòng không để trống Chủ đề")]
        public Nullable<long> MaChuDe { get; set; }
        [Display(Name = "Tour nước ngoài")]
        [Required(ErrorMessage = "Vui lòng không để trống Tour nước ngoài")]
        public Nullable<long> MaTourNuocNgoai { get; set; }
        [Display(Name = "Tour trong nước")]
        [Required(ErrorMessage = "Vui lòng không để trống Tour trong nước")]
        public Nullable<long> MaTourTrongNuoc { get; set; }
        [Display(Name = "Địa điểm hot nước ngoài")]
        [Required(ErrorMessage = "Vui lòng không để trống Địa điểm hot nước ngoài")]
        public Nullable<long> MaDiaDiemHotNuocNgoai { get; set; }
        [Display(Name = "Địa điểm hot trong nước")]
        [Required(ErrorMessage = "Vui lòng không để trống Địa điểm hot trong nước")]
        public Nullable<long> MaDiaDiemHotTrongNuoc { get; set; }

      
        public virtual DiaDiemHotNuocNgoai DiaDiemHotNuocNgoai { get; set; }
        public virtual DiaDiemHotTrongNuoc DiaDiemHotTrongNuoc { get; set; }
        public virtual LoaiTour LoaiTour { get; set; }
        public virtual TourNuocNgoai TourNuocNgoai { get; set; }
        public virtual TourTheoChuDe TourTheoChuDe { get; set; }
        public virtual TourTrongNuoc TourTrongNuoc { get; set; }
    }
}