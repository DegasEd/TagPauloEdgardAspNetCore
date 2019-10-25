using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TagShop.Api.ViewModels.Customers;

namespace TagShop.Api.ViewModels.Carts
{
    public class CartViewModel
    {
        public CartViewModel()
        {
            Client = new ClientViewModel();
        }

        public long Id { get; protected set; }
        public Guid Key { get; private set; }
        public string CartId { get; set; }
        public ClientViewModel Client { get; set; }
        public List<CartItemViewModel> CartItems { get; set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime UpdatedDate { get; private set; }
        public bool IsActive { get; private set; }
    }
}
