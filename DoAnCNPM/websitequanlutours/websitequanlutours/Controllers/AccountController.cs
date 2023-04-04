using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using websitequanlutours.Identity;
using websitequanlutours.ViewModel;

namespace websitequanlutours.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(DangKy rmv)
        {
            if (ModelState.IsValid)
            {
                var appDbContext = new AppDbContext();
                var userStore = new AppUserStore(appDbContext);
                var userManager = new AppUserManager(userStore);
                var passwdHash = Crypto.HashPassword(rmv.Password);
                var user = new AppUser()
                {
                    Email = rmv.Email,
                    UserName = rmv.Username,
                    PasswordHash = passwdHash,
                    DiaChi = rmv.DiaChi,
                    NgaySinh = rmv.Birthday,
                    PhoneNumber = rmv.Mobile,
                };
                IdentityResult identityResult = userManager.Create(user);
                if (identityResult.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Customer");

                    var anthenManager = HttpContext.GetOwinContext().Authentication;

                    var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                    anthenManager.SignIn(new AuthenticationProperties(), userIdentity);
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("New Error", "Invalid Data");
                return View();
            }



        }
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(DangKy lvm)
        {
            var appDbContext = new AppDbContext();
            var userStore = new AppUserStore(appDbContext);
            var userManager = new AppUserManager(userStore);
            if (string.IsNullOrWhiteSpace(lvm.Username) || string.IsNullOrWhiteSpace(lvm.Password))
            {
                ModelState.AddModelError("myError", "Username and password are required.");
                ViewBag.ThongBao = "Vui lòng nhập đầy đủ thông tin đăng nhập";
                return View();
            }

            var user = userManager.Find(lvm.Username, lvm.Password);
            if (user !=null)
            {
                var anthenManager = HttpContext.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                anthenManager.SignIn(new AuthenticationProperties(), userIdentity);


                if (userManager.IsInRole(user.Id, "Admin"))
                {
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                else
                {

                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("myError", "Invalid username and password.");

                ViewBag.ThongBao = "Tài khoản hay mật khẩu không đúng";
                return View();
            }
        }
        public ActionResult Logout()
        {
            var anthenManager = HttpContext.GetOwinContext().Authentication;
            anthenManager.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}