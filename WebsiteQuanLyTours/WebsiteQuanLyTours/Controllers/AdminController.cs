using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteQuanLyTours.Models;

namespace WebsiteQuanLyTours.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        quanlytoursDBContext db = new quanlytoursDBContext();
        [HttpGet]
        public ActionResult Admin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Admin(FormCollection f)
        {


            string sTaiKhoan = f["txtTaiKhoan"].ToString();
            string sMatKhau = f.Get("txtMatKhau").ToString();

          //  TkMkAdmin kh = db.TkMkAdmins.SingleOrDefault(n => n.TaiKhoan == sTaiKhoan && n.MatKhau == sMatKhau);
      //      if (kh != null)
            {
                ViewBag.ThongBao = "Chúc mừng bạn đăng nhập thành công! ";
        //        Session["TaiKhoan"] = kh;

                // return View();
                return RedirectToAction("Index", "QuanLySanPham");

            }
            ViewBag.ThongBao = "Tên tài khoản hoặc mật khẩu không đúng! ";
            return View();


        }
        //dang xuat admin


        public ActionResult SignOut()
        {


            Session.Clear();
            return RedirectToAction("Admin", "Admin");
        }


    }
}