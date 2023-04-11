using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using websitequanlutours.Filters;
using websitequanlutours.Models;
using WebsiteQuanLyTours.Models;

namespace websitequanlutours.Areas.Admin.Controllers
{
    [AdminAuthorization]
    public class LoaiToursController : Controller
    {
        // GET: Admin/LoaiTours
        quanlytoursDBContext db = new quanlytoursDBContext();





        public ActionResult Index(string search = "")
        {


            // List<Tour> tours = db.Tours.ToList();
            List<LoaiTour> loaiTours = db.LoaiTours.Where(row => row.LoaiTours.Contains(search)).ToList();
            ViewBag.Search = search;
            return View(loaiTours);

        }
        public ActionResult ChinhSua(int id)
        {
            LoaiTour tour = db.LoaiTours.Where(row => row.MaLoaiTour == id).FirstOrDefault();
            return View(tour);
        }
        [HttpPost]
        public ActionResult ChinhSua(LoaiTour pro)
        {

            LoaiTour tour = db.LoaiTours.Where(row => row.MaLoaiTour == pro.MaLoaiTour).FirstOrDefault();

            //update

            tour.LoaiTours = pro.LoaiTours;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult ThemMoi()
        {

            ViewBag.LoaiTours = db.LoaiTours.ToList();
            ViewBag.TourTheoChuDe = db.TourTheoChuDes.ToList();
            ViewBag.TourNuocNgoai = db.TourNuocNgoais.ToList();
            ViewBag.TourTrongNuoc = db.TourTrongNuocs.ToList();
            ViewBag.DiaDiemHotNuocNgoai = db.DiaDiemHotNuocNgoais.ToList();
            ViewBag.DiaDiemHotTrongNuoc = db.DiaDiemHotTrongNuocs.ToList();


            return View();
        }

        [HttpPost]
        public ActionResult ThemMoi(Tour p)
        {
            if (ModelState.IsValid)
            {

                db.tours.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("ThemMoi");
            }

        }
        public ActionResult Xoa(int id)
        {
            LoaiTour tour = db.LoaiTours.Where(row => row.MaLoaiTour == id).FirstOrDefault();
            return View(tour);
        }

        [HttpPost]
        public ActionResult Xoa(int id, LoaiTour p)
        {
            LoaiTour tour = db.LoaiTours.Where(row => row.MaLoaiTour == id).FirstOrDefault();
            db.LoaiTours.Remove(tour);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}