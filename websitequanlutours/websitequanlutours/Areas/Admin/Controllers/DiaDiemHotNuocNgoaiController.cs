using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using websitequanlutours.Models;
using websitequanlutours.Filters;

namespace websitequanlutours.Areas.Admin.Controllers
{
    [AdminAuthorization]
    public class DiaDiemHotNuocNgoaiController : Controller
    {
        // GET: Admin/DiaDiemHotNuocNgoai
        quanlytoursDBContext db = new quanlytoursDBContext();





        public ActionResult Index(string search = "")
        {


            // List<Tour> tours = db.Tours.ToList();
            List<DiaDiemHotNuocNgoai> diaDiemHotNuocNgoais = db.DiaDiemHotNuocNgoais.Where(row => row.DiaDiemHotNuocNgoai1.Contains(search)).ToList();
            ViewBag.Search = search;
            return View(diaDiemHotNuocNgoais);

        }



        public ActionResult ThemMoi()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThemMoi(DiaDiemHotNuocNgoai p)
        {

            if (ModelState.IsValid)
            {

                db.DiaDiemHotNuocNgoais.Add(p);
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
            DiaDiemHotNuocNgoai tour = db.DiaDiemHotNuocNgoais.Where(row => row.MaDiaDiemHotNuocNgoai == id).FirstOrDefault();
            return View(tour);
        }
        [HttpPost]
        public ActionResult ChinhSua(DiaDiemHotNuocNgoai pro)
        {

            DiaDiemHotNuocNgoai tour = db.DiaDiemHotNuocNgoais.Where(row => row.MaDiaDiemHotNuocNgoai == pro.MaDiaDiemHotNuocNgoai).FirstOrDefault();



            //update

            tour.DiaDiemHotNuocNgoai1 = pro.DiaDiemHotNuocNgoai1;

            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Xoa(int id)
        {
            DiaDiemHotNuocNgoai tour = db.DiaDiemHotNuocNgoais.Where(row => row.MaDiaDiemHotNuocNgoai == id).FirstOrDefault();
            return View(tour);
        }

        [HttpPost]
        public ActionResult Xoa(int id, DiaDiemHotNuocNgoai p)
        {
            DiaDiemHotNuocNgoai tour = db.DiaDiemHotNuocNgoais.Where(row => row.MaDiaDiemHotNuocNgoai == id).FirstOrDefault();
            db.DiaDiemHotNuocNgoais.Remove(tour);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}