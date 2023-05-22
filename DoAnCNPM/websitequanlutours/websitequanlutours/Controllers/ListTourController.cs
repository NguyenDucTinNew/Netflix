using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace websitequanlutours.Controllers
{
    public class ListTourController : Controller
    {
        // GET: ListTour
        public ActionResult TourList()
        {
            return View();
        }
    }
}