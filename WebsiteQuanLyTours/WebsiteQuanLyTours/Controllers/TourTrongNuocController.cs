using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteQuanLyTours.Models;

namespace WebsiteQuanLyTours.Controllers
{
    public class TourTrongNuocController : Controller
    {
        // GET: TourTrongNuoc
        quanlytoursDBContext db = new quanlytoursDBContext();





        public ActionResult Index(string search = "")
        {


            // List<Tour> tours = db.Tours.ToList();
            List<TourTrongNuoc> tourTrongNuocs = db.TourTrongNuocs.Where(row => row.TourTrongNuoc1.Contains(search)).ToList();
            ViewBag.Search = search;
            return View(tourTrongNuocs);

        }



        public ActionResult ThemMoi()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThemMoi(TourTrongNuoc p)
        {
            if (ModelState.IsValid)
            {

                db.TourTrongNuocs.Add(p);
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
            TourTrongNuoc tour = db.TourTrongNuocs.Where(row => row.MaTourTrongNuoc == id).FirstOrDefault();
            return View(tour);
        }
        [HttpPost]
        public ActionResult ChinhSua(TourTrongNuoc pro)
        {

            TourTrongNuoc tour = db.TourTrongNuocs.Where(row => row.MaTourTrongNuoc == pro.MaTourTrongNuoc).FirstOrDefault();



            //update

            tour.TourTrongNuoc1 = pro.TourTrongNuoc1;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Xoa(int id)
        {
            TourTrongNuoc tour = db.TourTrongNuocs.Where(row => row.MaTourTrongNuoc == id).FirstOrDefault();
            return View(tour);
        }

        [HttpPost]
        public ActionResult Xoa(int id, TourTrongNuoc p)
        {
            TourTrongNuoc tour = db.TourTrongNuocs.Where(row => row.MaTourTrongNuoc == id).FirstOrDefault();
            db.TourTrongNuocs.Remove(tour);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}