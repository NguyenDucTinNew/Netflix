using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebsiteQuanLyTours.Models;

namespace WebsiteQuanLyTours.Models
{
    public class quanlytoursDBContext : DbContext
    {
        public quanlytoursDBContext() : base("MyConnectionString") { }
        public DbSet<Tour> tours { get; set; }
        public DbSet<LoaiTour> LoaiTours { get; set; }
        public DbSet<TourTheoChuDe> TourTheoChuDes { get; set; }
        public DbSet<TourNuocNgoai> TourNuocNgoais { get; set; }
        public DbSet<TourTrongNuoc> TourTrongNuocs { get; set; }
        public DbSet<DiaDiemHotNuocNgoai> DiaDiemHotNuocNgoais { get; set; }
        public DbSet<DiaDiemHotTrongNuoc> DiaDiemHotTrongNuocs { get; set; }
       // public DbSet<DonHangTour> donHangTours { get; set; }
       // public DbSet<ChiTietDonHangTour> chiTietDonHangTours { get; set; }
       // public DbSet<KhachHangTour> khachHangTours { get; set; }
    }
}