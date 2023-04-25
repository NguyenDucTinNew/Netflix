using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using websitequanlutours.Models;



namespace websitequanlutours.Controllers
{
    public class GioHangController : Controller
    {
        // GET: GioHang
        private quanlytoursDBContext db = new quanlytoursDBContext();

        /* // Action hiển thị giỏ hàng
         public ActionResult Index()
         {
             // Lấy giỏ hàng của người dùng hiện tại
             var cart = GetCart();

             // Chuyển đổi danh sách CartItem từ Cart
             List<CartItem> cartItems = cart.CartItems.ToList();

             return View(cartItems);
         }



         // Action thêm sản phẩm vào giỏ hàng
         public ActionResult AddToCart(int itemId, int quantity)
         {
             // Lấy sản phẩm từ database dựa trên itemId
             var tour = db.tours.FirstOrDefault(t => t.MaTour == itemId);

             if (itemId <= 0 || quantity <= 0)
             {
                 // Xử lý trường hợp giá trị quantity là null hoặc không hợp lệ
                 // Ví dụ: trả về một thông báo lỗi hoặc chuyển hướng đến một trang lỗi
                 return RedirectToAction("Error", "Home");
             }

             // Lấy giỏ hàng của người dùng hiện tại
             var cart = GetCart();

             // Kiểm tra xem sản phẩm đã có trong giỏ hàng hay chưa
             var existingCartItem = cart.CartItems.FirstOrDefault(item => item.MaTour == itemId);
             if (existingCartItem != null)
             {
                 // Nếu đã có trong giỏ hàng thì tăng số lượng lên
                 existingCartItem.SoLuong += quantity;
             }
             else
             {
                 // Nếu chưa có thì thêm vào giỏ hàng
                 var newCartItem = new CartItem
                 {
                     MaTour = itemId,
                     // Gán các thuộc tính của "tour" vào "CartItem"
                     SoLuong = quantity,
                     DonGia = tour.Gia,
                     Tour = tour
                 };
                 cart.CartItems.Add(newCartItem);

                 // Add the newCartItem to the context and save changes
                 db.CartItems.Add(newCartItem);
                 db.SaveChanges();
             }

             // Cập nhật giỏ hàng trong session
             Session["Cart"] = cart;

             return RedirectToAction("Index");
         }*/




        // GET: /Cart/
        /*public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var cart = db.Carts.FirstOrDefault(c => c.AppUserId == userId);
            if (cart == null)
            {
                cart = new Cart { AppUserId = userId };
                db.Carts.Add(cart);
                db.SaveChanges();
            }
            return View(cart);
        }*/

        // POST: /Cart/AddToCart/5
        /*[HttpPost]
        public ActionResult AddToCart(int id, int quantity)
        {
            var userId = User.Identity.GetUserId();
            var cart = db.Carts.FirstOrDefault(c => c.AppUserId == userId);
            if (cart == null)
            {
                cart = new Cart { AppUserId = userId };
                db.Carts.Add(cart);
            }

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.IdItem == id);
            if (cartItem == null)
            {
                cartItem = new CartItem { IdItem = id, SoLuong = quantity, AppUserId = cart.IdCart };
                db.CartItems.Add(cartItem);
            }
            else
            {
                cartItem.SoLuong += quantity;
            }

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: /Cart/RemoveFromCart/5
        public ActionResult RemoveFromCart(int id)
        {
            var userId = User.Identity.GetUserId();
            var cart = db.Carts.FirstOrDefault(c => c.AppUserId == userId);
            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.IdItem == id);
            if (cartItem != null)
            {
                db.CartItems.Remove(cartItem);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }*/
        public ActionResult Index()
        {
            string cart = Request.Cookies["Cart"]?.Value;

            var cartItems = new List<CartItem>();

            if (!string.IsNullOrEmpty(cart))
            {
                cartItems = JsonConvert.DeserializeObject<List<CartItem>>(cart);
            }

            return View(cartItems);
        }

        public ActionResult AddToCart(int id)
        {
            string cart = Request.Cookies["Cart"]?.Value;
            var items = new List<CartItem>();

            if (!string.IsNullOrEmpty(cart))
            {
                items = JsonConvert.DeserializeObject<List<CartItem>>(cart);
            }

            var tour = db.tours.Find(id);
            if (tour != null)
            {
                var cartItem = items.FirstOrDefault(x => x.Tour.TourId == id);
                if (cartItem != null)
                {
                    cartItem.Quantity++;
                }
                else
                {
                    var newCartItem = new CartItem { Quantity = 1 };
                    newCartItem.Tour = tour;
                    items.Add(newCartItem);
                }
            }

            var json = JsonConvert.SerializeObject(items);
            var cookie = new HttpCookie("Cart", json);

            Response.Cookies.Set(cookie);

            return RedirectToAction("Index");
        }
    }
}


