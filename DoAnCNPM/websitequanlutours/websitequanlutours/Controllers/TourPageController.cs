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
        // GET: TourPage
        [MyAuthenFilter]
       
        public ActionResult Index()
        {
            quanlytoursDBContext db = new quanlytoursDBContext();
            List<Tour> tours = db.tours.ToList();
            return View(tours);
        }
    }
}