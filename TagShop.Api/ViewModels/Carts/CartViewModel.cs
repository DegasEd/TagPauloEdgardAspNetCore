using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TagShop.Api.ViewModels.CartItems;
using TagShop.Api.ViewModels.Customers;

namespace TagShop.Api.ViewModels.Carts
{
    public class CartViewModel
    {
        public Guid Key { get; private set; }
        public long ClientId { get; set; }
        public List<CartItemViewModel> CartItems { get; set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime UpdatedDate { get; private set; }
        public bool IsActive { get; private set; }
    }
}
