using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using websitequanlutours.Models;
using websitequanlutours.Identity;
using websitequanlutours.Filters;

namespace websitequanlutours.Areas.Admin.Controllers
{
    [AdminAuthorization]
    public class UsersController : Controller
    { 
       
        // GET: Admin/Users
        public ActionResult Index()
        {
            AppDbContext db = new AppDbContext();
            List<AppUser> users = db.Users.ToList();
            return View(users);
        }
    }
}