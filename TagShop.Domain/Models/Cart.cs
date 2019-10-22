using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Abstract;

namespace TagShop.Domain.Models
{
    public class Cart : BaseEntity
    {
        public Cart()
        {
            Client = new Client();
        }

        
        public string CartId { get; set; }
        public Client Client { get; set; }
        public List<CartItem> CartItems { get; set; }

    }
}
