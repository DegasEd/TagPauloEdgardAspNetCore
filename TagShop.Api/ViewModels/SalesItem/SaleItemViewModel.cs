using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagShop.Api.ViewModels.SalesItem
{
    public class SaleItemViewModel
    {
        public long Id { get; protected set; }
        public Guid Key { get; protected set; }
        public DateTime CreatedDate { get; protected set; }
        public DateTime UpdatedDate { get; protected set; }
        public bool IsActive { get; private set; }
        public long SaleId { get; set; }
        public long ProductId { get; set; }
        public int Amount { get; set; }
        public long UnitaryValue { get; set; }

    }
}
