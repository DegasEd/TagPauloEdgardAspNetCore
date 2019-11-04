using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagShop.Api.ViewModels.CartItems
{
    public class CreateCartItemViewModel
    {
        public Guid Cartkey { get; set; }
        public Guid Productkey { get; set; }
        public Int32 Amount { get; set; }
    }
}
