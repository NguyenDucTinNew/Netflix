using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using websitequanlutours.Models;

namespace websitequanlutours.Areas.Admin.Controllers
{
    public class QuanLyToursController : Controller
    {
        // GET: Admin/QuanLyTours
        quanlytoursDBContext db = new quanlytoursDBContext();





        public ActionResult Index(string search = "", string SortColumn = "MaTour", string IconClass = "fa-sort-asc", int page = 1)
        {


            // List<Tour> tours = db.Tours.ToList();
            List<Tour> tours = db.tours.Where(row => row.TenTour.Contains(search)).ToList();
            ViewBag.Search = search;


            //short
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;

            if (SortColumn == "MaTour")
            {
                if (IconClass == "fa-sort-asc")
                {
                    tours = tours.OrderBy(row => row.TourId).ToList();
                }
                else
                {
                    tours = tours.OrderByDescending(row => row.TourId).ToList();
                }

            }
            else if (SortColumn == "TenTour")
            {
                if (IconClass == "fa-sort-asc")
                {
                    tours = tours.OrderBy(row => row.TenTour).ToList();
                }
                else
                {
                    tours = tours.OrderByDescending(row => row.TenTour).ToList();
                }
            }
            else if (SortColumn == "ThoiGianTour")
            {
                if (IconClass == "fa-sort-asc")
                {
                    tours = tours.OrderBy(row => row.ThoiGianTour).ToList();
                }
                else
                {
                    tours = tours.OrderByDescending(row => row.ThoiGianTour).ToList();
                }
            }
            else if (SortColumn == "Gia")
            {
                if (IconClass == "fa-sort-asc")
                {
                    tours = tours.OrderBy(row => row.Gia).ToList();
                }
                else
                {
                    tours = tours.OrderByDescending(row => row.Gia).ToList();
                }
            }


            //paging
            int NoOfRecordPerPage = 5;
            int NoOfPages = Convert.ToInt32(Math.Ceiling
                (Convert.ToDouble(tours.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int NoOfRecordToSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.Page = page;
            ViewBag.NoOfPages = NoOfPages;
            tours = tours.Skip(NoOfRecordToSkip).Take(NoOfRecordPerPage).ToList();

            return View(tours);


        }

        public ActionResult HienThi(int id)
        {

            Tour pro = db.tours.Where(row => row.TourId == id).FirstOrDefault();
            return View(pro);
        }


        public ActionResult ThemMoi()
        {



          /*  ViewBag.LoaiTours = db.LoaiTours.ToList();
            if (ViewBag.LoaiTours != null && ViewBag.LoaiTours.Count == 0)
                ViewBag.LoaiTours.Add(new LoaiTour());

            ViewBag.TourTheoChuDe = db.TourTheoChuDes.ToList();
            if (ViewBag.TourTheoChuDe != null && ViewBag.TourTheoChuDe.Count == 0)
                ViewBag.TourTheoChuDe.Add(new TourTheoChuDe());

            ViewBag.TourNuocNgoai = db.TourNuocNgoais.ToList();
            if (ViewBag.TourNuocNgoai != null && ViewBag.TourNuocNgoai.Count == 0)
                ViewBag.TourNuocNgoai.Add(new TourNuocNgoai());


            ViewBag.TourTrongNuoc = db.TourTrongNuocs.ToList();
            if (ViewBag.TourTrongNuoc != null && ViewBag.TourTrongNuoc.Count == 0)
                ViewBag.TourTrongNuoc.Add(new TourTrongNuoc());

            ViewBag.DiaDiemHotNuocNgoai = db.DiaDiemHotNuocNgoais.ToList();
            if (ViewBag.DiaDiemHotNuocNgoai != null && ViewBag.DiaDiemHotNuocNgoai.Count == 0)
                ViewBag.DiaDiemHotNuocNgoai.Add(new DiaDiemHotNuocNgoai());

            ViewBag.DiaDiemHotTrongNuoc = db.DiaDiemHotTrongNuocs.ToList();
            if (ViewBag.DiaDiemHotTrongNuoc != null && ViewBag.DiaDiemHotTrongNuoc.Count == 0)
                ViewBag.DiaDiemHotTrongNuoc.Add(new DiaDiemHotTrongNuoc());
*/
            return View();
        }

        [HttpPost]
        
        public ActionResult ThemMoi(Tour p
            , HttpPostedFileBase imageFile
        )
        {
            if (ModelState.IsValid)
            {
                if (imageFile != null && imageFile.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(imageFile.FileName);
                    var path = Path.Combine(Server.MapPath("~/HinhAnh/"), fileName);
                    imageFile.SaveAs(path);
                }


                db.tours.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {

              /*  // hiển thị thông báo lỗi
                ViewBag.LoaiTours = db.LoaiTours.ToList();
                if (ViewBag.LoaiTours != null && ViewBag.LoaiTours.Count == 0)
                    ViewBag.LoaiTours.Add(new LoaiTour());

                ViewBag.TourTheoChuDe = db.TourTheoChuDes.ToList();
            if (ViewBag.TourTheoChuDe != null && ViewBag.TourTheoChuDe.Count == 0)
                ViewBag.TourTheoChuDe.Add(new TourTheoChuDe());

            ViewBag.TourNuocNgoai = db.TourNuocNgoais.ToList();
            if (ViewBag.TourNuocNgoai != null && ViewBag.TourNuocNgoai.Count == 0)
                ViewBag.TourNuocNgoai.Add(new TourNuocNgoai());


            ViewBag.TourTrongNuoc = db.TourTrongNuocs.ToList();
            if (ViewBag.TourTrongNuoc != null && ViewBag.TourTrongNuoc.Count == 0)
                ViewBag.TourTrongNuoc.Add(new TourTrongNuoc());

            ViewBag.DiaDiemHotNuocNgoai = db.DiaDiemHotNuocNgoais.ToList();
            if (ViewBag.DiaDiemHotNuocNgoai != null && ViewBag.DiaDiemHotNuocNgoai.Count == 0)
                ViewBag.DiaDiemHotNuocNgoai.Add(new DiaDiemHotNuocNgoai());

            ViewBag.DiaDiemHotTrongNuoc = db.DiaDiemHotTrongNuocs.ToList();
            if (ViewBag.DiaDiemHotTrongNuoc != null && ViewBag.DiaDiemHotTrongNuoc.Count == 0)
                ViewBag.DiaDiemHotTrongNuoc.Add(new DiaDiemHotTrongNuoc());*/
            return View(p);

            }    

        }

        public ActionResult ChinhSua(int id)
        {
            Tour tour = db.tours.Where(row => row.TourId == id).FirstOrDefault();
         /*   ViewBag.LoaiTours = db.LoaiTours.ToList();
            ViewBag.TourTheoChuDe = db.TourTheoChuDes.ToList();
            ViewBag.TourNuocNgoai = db.TourNuocNgoais.ToList();
            ViewBag.TourTrongNuoc = db.TourTrongNuocs.ToList();
            ViewBag.DiaDiemHotNuocNgoai = db.DiaDiemHotNuocNgoais.ToList();
            ViewBag.DiaDiemHotTrongNuoc = db.DiaDiemHotTrongNuocs.ToList();*/
            return View(tour);
        }
        [HttpPost]
        public ActionResult ChinhSua(Tour pro)
        {

            Tour tour = db.tours.Where(row => row.TourId == pro.TourId).FirstOrDefault();


            if (pro.TenTour == null || pro.ThoiGianTour == null || pro.Gia == null)
            {
                ModelState.AddModelError("", "Vui lòng nhập đầy đủ thông tin.");
            }


            if (ModelState.IsValid)
            {

            //update
            tour.TenTour = pro.TenTour;
            tour.ThoiGianTour = pro.ThoiGianTour;
            tour.Gia = pro.Gia;
            tour.ChuongTrinhTour = pro.ChuongTrinhTour;
            tour.ImageFile = pro.ImageFile;
        /*    tour.MaLoaiTour = pro.MaLoaiTour;
            tour.MaChuDe = pro.MaChuDe;
            tour.MaTourTrongNuoc = pro.MaTourTrongNuoc;
            tour.MaTourNuocNgoai = pro.MaTourNuocNgoai;
            tour.MaDiaDiemHotTrongNuoc = pro.MaDiaDiemHotTrongNuoc;
            tour.MaDiaDiemHotNuocNgoai = pro.MaDiaDiemHotNuocNgoai;*/
            db.SaveChanges();

            return RedirectToAction("Index");
            }
             
                // hiển thị thông báo lỗi
                
              /*  ViewBag.LoaiTours = db.LoaiTours.ToList();
                ViewBag.TourTheoChuDe = db.TourTheoChuDes.ToList();
                ViewBag.TourNuocNgoai = db.TourNuocNgoais.ToList();
                ViewBag.TourTrongNuoc = db.TourTrongNuocs.ToList();
                ViewBag.DiaDiemHotNuocNgoai = db.DiaDiemHotNuocNgoais.ToList();
                ViewBag.DiaDiemHotTrongNuoc = db.DiaDiemHotTrongNuocs.ToList();*/
            /*                ViewBag.h1 = "Không để trống";
            */
            ViewBag.h1 = "Vui lòng không để trống";      
            return View(pro);
           
        }
        public ActionResult Xoa(int id)
        {
            Tour tour = db.tours.Where(row => row.TourId == id).FirstOrDefault();
            return View(tour);
        }

        [HttpPost]
        public ActionResult Xoa(int id, Tour p)
        {
            Tour tour = db.tours.Where(row => row.TourId == id).FirstOrDefault();
            db.tours.Remove(tour);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

      
    }
}