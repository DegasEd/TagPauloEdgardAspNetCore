using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Abstract;

namespace TagShop.Domain.Models
{
    public class Product : BaseEntity
    {
        public Product()
        {
            Images = new List<Image>();
        }
        
        public long CategoryId { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public decimal Price { get; set; }
        public int StockAmount { get; set; }
        public List<Image> Images { get; set; }

    }
}
