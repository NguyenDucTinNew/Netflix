using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace websitequanlutours.ViewModel
{
    public class DangNhap
    {
        [Required(ErrorMessage = "Không để trống Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Không để trống Password")]
        public string Password { get; set; } 
    }
}