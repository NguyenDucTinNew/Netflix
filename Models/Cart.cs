using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace websitequanlutours.Models
{
    public class Cart
    {
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}