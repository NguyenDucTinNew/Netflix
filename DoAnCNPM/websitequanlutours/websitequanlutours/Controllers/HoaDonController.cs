using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using websitequanlutours.Models;

namespace websitequanlutours.Controllers
{
    public class HoaDonController : Controller
    {
        // GET: HoaDon
        private quanlytoursDBContext db = new quanlytoursDBContext();


       public ActionResult Index()
        {
            // Get all orders from the database
           

            // Pass the list of orders to the view for display
            return View();
        }

        // GET: Order/Details/5
       /* public ActionResult Details(int id)
        {
            // Get the order with the given ID from the database, including its associated CartItem
            var order = db.HoaDons.Include(o => o.CartItem).FirstOrDefault(o => o.MaHoaDon == id);

            if (order == null)
            {
                // If the order does not exist, redirect to an error page
                return RedirectToAction("Error");
            }

            // Pass the order and its associated CartItem to the view for display
            return View(order);
        }*/
    }
}