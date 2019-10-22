using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Abstract;

namespace TagShop.Domain.Models
{
    public class SaleItem : BaseEntity
    {
        
        public string SaleItemId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public decimal UnitaryValue { get; set; }
    }
}
