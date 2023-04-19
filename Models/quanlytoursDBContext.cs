using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using websitequanlutours.Models;

using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity.EntityFramework;
using websitequanlutours.Identity;

namespace websitequanlutours.Models
{
    public class quanlytoursDBContext : IdentityDbContext<AppUser>
    {
        public quanlytoursDBContext() : base("MyConnectionString") { }
        public DbSet<Tour> tours { get; set; }
        public DbSet<LoaiTour> LoaiTours { get; set; }
        public DbSet<TourTheoChuDe> TourTheoChuDes { get; set; }
        public DbSet<TourNuocNgoai> TourNuocNgoais { get; set; }
        public DbSet<TourTrongNuoc> TourTrongNuocs { get; set; }
        public DbSet<DiaDiemHotNuocNgoai> DiaDiemHotNuocNgoais { get; set; }
        public DbSet<DiaDiemHotTrongNuoc> DiaDiemHotTrongNuocs { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<TinhTrangTour> TinhTrangTours { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }





        // public DbSet<KhachHangTour> khachHangTours { get; set; }
    }
}