using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagShop.Api.ViewModels.SalesItem
{
    public class CreateSaleItemViewModel
    {
        public long SaleId { get; set; }
        public long ProductId { get; set; }
        public int Amount { get; set; }
        public long UnitaryValue { get; set; }
    }
}
