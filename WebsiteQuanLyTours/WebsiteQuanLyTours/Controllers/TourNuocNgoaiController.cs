using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteQuanLyTours.Models;

namespace WebsiteQuanLyTours.Controllers
{
    public class TourNuocNgoaiController : Controller
    {
        // GET: TourNuocNgoai
        quanlytoursDBContext db = new quanlytoursDBContext();





        public ActionResult Index(string search = "")
        {


            // List<Tour> tours = db.Tours.ToList();
            List<TourNuocNgoai> tourNuocNgoais = db.TourNuocNgoais.Where(row => row.TourNuocNgoai1.Contains(search)).ToList();
            ViewBag.Search = search;
            return View(tourNuocNgoais);

        }



        public ActionResult ThemMoi()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThemMoi(TourNuocNgoai p)
        {
            if (ModelState.IsValid)
            {

                db.TourNuocNgoais.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("ThemMoi");
            }
        }

        public ActionResult ChinhSua(int id)
        {
            TourNuocNgoai tour = db.TourNuocNgoais.Where(row => row.MaTourNuocNgoai == id).FirstOrDefault();
            return View(tour);
        }
        [HttpPost]
        public ActionResult ChinhSua(TourNuocNgoai pro)
        {

            TourNuocNgoai tour = db.TourNuocNgoais.Where(row => row.MaTourNuocNgoai == pro.MaTourNuocNgoai).FirstOrDefault();



            //update

            tour.TourNuocNgoai1 = pro.TourNuocNgoai1;

            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Xoa(int id)
        {
           TourNuocNgoai tour = db.TourNuocNgoais.Where(row => row.MaTourNuocNgoai == id).FirstOrDefault();
            return View(tour);
        }

        [HttpPost]
        public ActionResult Xoa(int id, TourNuocNgoai p)
        {
            TourNuocNgoai tour = db.TourNuocNgoais.Where(row => row.MaTourNuocNgoai == id).FirstOrDefault();
            db.TourNuocNgoais.Remove(tour);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}