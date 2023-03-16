using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteQuanLyTours.Models;

namespace WebsiteQuanLyTours.Controllers
{
    public class TourTheoChuDeController : Controller
    {
        // GET: TourTheoChuDe
        quanlytoursDBContext db = new quanlytoursDBContext();





        public ActionResult Index(string search = "")
        {


            // List<Tour> tours = db.Tours.ToList();
            List<TourTheoChuDe> tourTheoChuDes = db.TourTheoChuDes.Where(row => row.TourTheoChuDe1.Contains(search)).ToList();
            ViewBag.Search = search;
            return View(tourTheoChuDes);

        }



        public ActionResult ThemMoi()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThemMoi(TourTheoChuDe p)
        {
            if (ModelState.IsValid)
            {

                db.TourTheoChuDes.Add(p);
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
            TourTheoChuDe tour = db.TourTheoChuDes.Where(row => row.MaChuDe == id).FirstOrDefault();
            return View(tour);
        }
        [HttpPost]
        public ActionResult ChinhSua(TourTheoChuDe pro)
        {

            TourTheoChuDe tour = db.TourTheoChuDes.Where(row => row.MaChuDe == pro.MaChuDe).FirstOrDefault();



            //update

            tour.TourTheoChuDe1 = pro.TourTheoChuDe1;

            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Xoa(int id)
        {
            TourTheoChuDe tour = db.TourTheoChuDes.Where(row => row.MaChuDe == id).FirstOrDefault();
            return View(tour);
        }

        [HttpPost]
        public ActionResult Xoa(int id, TourTheoChuDe p)
        {
            TourTheoChuDe tour = db.TourTheoChuDes.Where(row => row.MaChuDe == id).FirstOrDefault();
            db.TourTheoChuDes.Remove(tour);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}