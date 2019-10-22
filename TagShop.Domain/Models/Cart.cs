using System;
using System.Collections.Generic;
using System.Text;

namespace TagShop.Domain.Models
{
    public class Cart : Entity
    {
        public Cart()
        {
            Client = new Client();
        }

        
        public string CartId { get; set; }
        public Client Client { get; set; }
        public List<CartItem> CartItems { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
