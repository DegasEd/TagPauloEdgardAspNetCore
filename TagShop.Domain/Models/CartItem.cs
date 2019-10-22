using System;
using System.Collections.Generic;
using System.Text;

namespace TagShop.Domain.Models
{
    public class CartItem : Entity
    {
        
        public string CartItemId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
