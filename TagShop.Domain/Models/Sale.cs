using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Abstract;

namespace TagShop.Domain.Models
{
    public class Sale : BaseEntity
    {
        public Sale()
        {
            Client = new Client();
            SaleItems = new List<SaleItem>();
        }
        
        public string SaleId { get; set; }
        public string Invoice { get; set; }
        public Client Client { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalPurchase { get; set; }
        public decimal Icms { get; set; }
        public decimal Pis { get; set; }
        public decimal Cofins { get; set; }
        public List<SaleItem> SaleItems { get; set; }

    }
}
