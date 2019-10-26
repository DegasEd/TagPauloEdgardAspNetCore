using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TagShop.Api.ViewModels.Customers;

namespace TagShop.Api.ViewModels.Sales
{
    public class SaleViewModel
    {
        public long Id { get; protected set; }
        public Guid Key { get; private set; }
        public long Invoice { get; set; }
        public long ClientId { get; set; }
        public DateTime SaleDate { get; set; }
        public long TotalPurchase { get; set; }
        public long Icms { get; set; }
        public long Pis { get; set; }
        public long Cofins { get; set; }
        public DateTime CreatedDate { get;  set; }
        public DateTime UpdatedDate { get;  set; }
        public bool IsActive { get;  set; }
    }
}
