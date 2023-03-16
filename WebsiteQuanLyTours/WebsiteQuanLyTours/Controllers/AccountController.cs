using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebsiteQuanLyTours.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account


        // truy cap vao admin
        public ActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "manager") 
            {
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return RedirectToAction("InvalidLogin");
            }    
        }


        //tao trang khi vao admin that bai
        public ActionResult InvalidLogin() 
        {
            return View(); 
        }
    }
}