﻿using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Abstract;

namespace TagShop.Domain.Models
{
    public class Sale : BaseEntity
    {
        public Sale()
        {
            SaleItems = new List<SaleItem>();
        }
        
        public long Invoice { get; set; }
        public long ClientId { get; set; }
        public DateTime SaleDate { get; set; }
        public long TotalPurchase { get; set; }
        public long Icms { get; set; }
        public long Pis { get; set; }
        public long Cofins { get; set; }
        public List<SaleItem> SaleItems { get; set; }


    }
}
