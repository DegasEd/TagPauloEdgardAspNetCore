using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagShop.Api.ViewModels.CartItems
{
    public class CartItemViewModel
    {
        public Guid Key { get; private set; }
        public Guid Cartkey { get; set; }
        public Guid ProductKey  { get; set; }
        public int Amount { get; set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime UpdatedDate { get; private set; }
        public bool IsActive { get; private set; }
    }
}
