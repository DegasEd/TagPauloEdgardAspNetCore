using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagShop.Api.ViewModels.Products
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateProductViewModel
    {
        public string Description { get; set; }
        public string Detail { get; set; }
        public long CategoryId { get; set; }
        public long Price { get; set; }
        public int StockAmount { get; set; }
    }
}
