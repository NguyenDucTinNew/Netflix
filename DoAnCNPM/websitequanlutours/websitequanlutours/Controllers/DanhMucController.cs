using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using websitequanlutours.Models;

namespace websitequanlutours.Controllers
{
    public class DanhMucController : Controller
    {
        quanlytoursDBContext db = new quanlytoursDBContext();
        // GET: DanhMuc
        public ActionResult Index()
        {
            return View();
        }

       
        
        public PartialViewResult LoaiTour()
        {
            var context = new quanlytoursDBContext();
            var loaiTourList = context.tours.Take(10).Select(t => t.LoaiTour).Distinct().ToList();
            return PartialView(loaiTourList);
        }

        public ViewResult TourTheoLoaiTour(string LoaiTour, int page = 1)
        {
            
            var lstSach = db.tours.Where(t => t.LoaiTour != null).ToList();
            if (lstSach.Count == 0)
            {
                ViewBag.Tour = "Không có tour nào thuộc loại tour này: " + LoaiTour;
                return View();
            }

            int NoOfRecordPerPage = 5;
            int NoOfPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(lstSach.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int NoOfRecordToSkip = (page - 1) * NoOfRecordPerPage;

            ViewBag.Page = page;
            ViewBag.NoOfPages = NoOfPages;

            lstSach = lstSach.Skip(NoOfRecordToSkip).Take(NoOfRecordPerPage).ToList();

            return View(lstSach);
        }
        public ViewResult DanhMucLoaiTour()
        {
            return View(db.tours.ToList());

        }



    }
}