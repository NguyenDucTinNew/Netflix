using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using websitequanlutours.Models;

namespace websitequanlutours.ViewModel
{
    public class DangKy
    {
        
       
        [Required(ErrorMessage = "Không để trống Username")]
        public string Username { get; set; }
        [Required(ErrorMessage =  "Không để trống Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = " Không để trống ConfirmPassword")]
        [Compare("Password",ErrorMessage ="không giống với password")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Không để trống Email")]
        [EmailAddress(ErrorMessage ="Email không tồn tại")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Không để trống Mobile")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Không để trống Ngày sinh")]
        public DateTime? Birthday { get; set; }
        [Required(ErrorMessage = "Không để trống địa chỉ")]
        public string DiaChi { get; set; }

       

    }
}