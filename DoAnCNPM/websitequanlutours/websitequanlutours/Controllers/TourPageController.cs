using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using websitequanlutours.Models;
using websitequanlutours.Filters;

namespace websitequanlutours.Controllers
{
    public class TourPageController : Controller
    {
        quanlytoursDBContext db = new quanlytoursDBContext();
        // GET: TourPage
        [MyAuthenFilter]
     
        public ActionResult DanhSachTour()
        {
            List<Tour> tours = db.tours.ToList();
            return View(tours);
        }

        public ActionResult HienThi(int id)
        {
            Tour pro = db.tours.Where(row => row.MaTour == id).FirstOrDefault();
            return View(pro);

        }
    }
}