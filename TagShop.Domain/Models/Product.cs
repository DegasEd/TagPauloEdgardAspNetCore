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
            Category = new Category();
            Images = new List<Image>();
        }
        
        public string ProductId { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public decimal Price { get; set; }
        public int StockAmount { get; set; }
        public List<Image> Images { get; set; }
    }
}
