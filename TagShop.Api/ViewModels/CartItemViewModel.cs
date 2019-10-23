using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagShop.Api.ViewModels
{
    public class CartItemViewModel
    {
        public long Id { get; protected set; }
        public Guid Key { get; private set; }
        public string CartItemId { get; set; }
        public ProductViewModel Product { get; set; }
        public int Amount { get; set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime UpdatedDate { get; private set; }
        public bool IsActive { get; private set; }
    }
}
