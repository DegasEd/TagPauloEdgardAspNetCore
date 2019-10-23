using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Abstract;

namespace TagShop.Domain.Models
{
    public class Cart : BaseEntity
    {
        
        public long ClientId { get; set; }
        public List<CartItem> CartItems { get; set; }

    }
}
