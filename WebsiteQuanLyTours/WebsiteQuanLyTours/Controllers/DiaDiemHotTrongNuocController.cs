using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteQuanLyTours.Models;

namespace WebsiteQuanLyTours.Controllers
{
    public class DiaDiemHotTrongNuocController : Controller
    {
        // GET: DiaDiemHotTrongNuoc
        quanlytoursDBContext db = new quanlytoursDBContext();





        public ActionResult Index(string search = "")
        {


            // List<Tour> tours = db.Tours.ToList();
            List<DiaDiemHotTrongNuoc> diemHotTrongNuocs = db.DiaDiemHotTrongNuocs.Where(row => row.DiaDiemHotTrongNuoc1.Contains(search)).ToList();
            ViewBag.Search = search;
            return View(diemHotTrongNuocs);

        }



        public ActionResult ThemMoi()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThemMoi(DiaDiemHotTrongNuoc p)
        {
            if (ModelState.IsValid)
            {

                db.DiaDiemHotTrongNuocs.Add(p);
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
            DiaDiemHotTrongNuoc tour = db.DiaDiemHotTrongNuocs.Where(row => row.MaDiaDiemHotTrongNuoc == id).FirstOrDefault();
            return View(tour);
        }
        [HttpPost]
        public ActionResult ChinhSua(DiaDiemHotTrongNuoc pro)
        {

            DiaDiemHotTrongNuoc tour = db.DiaDiemHotTrongNuocs.Where(row => row.MaDiaDiemHotTrongNuoc == pro.MaDiaDiemHotTrongNuoc).FirstOrDefault();



            //update

            tour.DiaDiemHotTrongNuoc1 = pro.DiaDiemHotTrongNuoc1;

            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Xoa(int id)
        {
            DiaDiemHotTrongNuoc tour = db.DiaDiemHotTrongNuocs.Where(row => row.MaDiaDiemHotTrongNuoc == id).FirstOrDefault();
            return View(tour);
        }

        [HttpPost]
        public ActionResult Xoa(int id, DiaDiemHotTrongNuoc p)
        {
            DiaDiemHotTrongNuoc tour = db.DiaDiemHotTrongNuocs.Where(row => row.MaDiaDiemHotTrongNuoc == id).FirstOrDefault();
            db.DiaDiemHotTrongNuocs.Remove(tour);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}