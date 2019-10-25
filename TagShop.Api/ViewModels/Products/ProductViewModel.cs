using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagShop.Api.ViewModels.Products 
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductViewModel
    {

        public long Id { get; set; }
        public Guid Key { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }
        public long CategoryId { get; set; }
        public long Price { get; set; }
        public int StockAmount { get; set; }        

    }
}
