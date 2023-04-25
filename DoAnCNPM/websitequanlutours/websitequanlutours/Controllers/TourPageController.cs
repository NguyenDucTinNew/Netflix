using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using websitequanlutours.Models;
using websitequanlutours.Filters;
using websitequanlutours.Identity;

namespace websitequanlutours.Controllers
{

    public class TourPageController : Controller
    {
        quanlytoursDBContext db = new quanlytoursDBContext();
        // GET: TourPage
        [MyAuthenFilter]

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


        public ActionResult HienThi (int id)
        {

            Tour pro = db.tours.Where(row => row.TourId == id).FirstOrDefault();
            return View(pro);
           
        }
    }
}