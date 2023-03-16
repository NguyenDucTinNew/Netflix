using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebsiteQuanLyTours.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tours()
        {
            return View("Tours");
        }
        public ActionResult LienHe() 
        {
            ViewBag.Phone = "1234";
            return View("LienHe");
        }

        public ActionResult GioiThieu()
        {
            return View("GioiThieu");
        }

        public ActionResult DieuKienDieuKhoan()
        {
            return View("DieuKienDieuKhoan");
        }
        public ActionResult CachThucChuyenDoiTraGop()
        {
            return View("CachThucChuyenDoiTraGop");
        }
        public ActionResult QuyCheHoatDong()
        {
            return View("QuyCheHoatDong");
        }
        public ActionResult ChinhSachRiengTu()
        {
            return View("ChinhSachRiengTu");
        }
        public ActionResult ChinhSachBaoMat()
        {
            return View("ChinhSachBaoMat");
        }
        public ActionResult TuyenDung()
        {
            return View("TuyenDung");
        }






        
        //truyen dulieu
        public ActionResult GetEmpName(int EmpId) 
        {
            var emloyees = new[]
            {
                new { EmpId = 1, EmpName = "Nghia", Salary = 8000 },
                new { EmpId = 1, EmpName = "Nghia", Salary = 8000 },
                new { EmpId = 1, EmpName = "Nghia", Salary = 8000 },
            };
            string matchEmpName = null;
            foreach (var item in emloyees)
            {
                if(item.EmpId == EmpId)
                {
                    matchEmpName = item.EmpName;
                }    
            }
        //    return new ContentResult() {Content = matchEmpName, ContentType="text/plain" };

            return Content(matchEmpName, "text/plain");
        }



        //cho phep ng dung down file 
        public ActionResult GetSalary(int EmpId) 
        {
            string fileName = "~/bang-luong-" + EmpId + ".pdf";
            return File(fileName, "application/pdf");
        }



        //ng dung truy cap fb
        public ActionResult EmpFbPage(int EmpId)
        {
            var emloyees = new[]
           {
                new { EmpId = 1, EmpName = "Nghia", Salary = 8000 },
                new { EmpId = 1, EmpName = "Nghia", Salary = 8000 },
                new { EmpId = 1, EmpName = "Nghia", Salary = 8000 },
            };
            string fbUrl = null;
            foreach (var item in emloyees)
            { 
                if(item.EmpId == EmpId)
                {
                    fbUrl = "https://www.facebool.com/emp" + EmpId;
                }    
            }
            if ( fbUrl == null)
            {
                return Content("Invalid emp ID");
            }    
            else
            {
                return Redirect(fbUrl);  
            }    
        }



        // hien thi thong tin ng dung
        public ActionResult EmpDetail()
        {
            ViewBag.EmpId = 101;
            ViewBag.Name = "Nghia";
            ViewBag.Salary = 1000;
            ViewBag.Gender = "M";
            ViewBag.Year = 2019;
            ViewBag.Positions = new List<string>() { "Security", "Technician", "Manager" };

            return View();
        }
    }
}