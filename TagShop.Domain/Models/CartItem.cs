using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Abstract;

namespace TagShop.Domain.Models
{
    public class CartItem : BaseEntity
    {
        public string CartId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }

    }
}
