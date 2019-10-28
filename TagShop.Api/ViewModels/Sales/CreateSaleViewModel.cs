using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TagShop.Api.ViewModels.Customers;

namespace TagShop.Api.ViewModels.Sales
{
    public class CreateSaleViewModel
    {
        public long ClientId { get; set; }
        public DateTime SaleDate { get; set; }
        public long TotalPurchase { get; set; }
        public long Icms { get; set; }
        public long Pis { get; set; }
        public long Cofins { get; set; }
    }
}
