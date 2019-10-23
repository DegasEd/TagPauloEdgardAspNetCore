using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagShop.Api.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            Category = new CategoryViewModel();
            Images = new List<ImageViewModel>();
        }

        public long Id { get; protected set; }
        public Guid Key { get; private set; }
        public string ProductId { get; set; }
        public CategoryViewModel Category { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public decimal Price { get; set; }
        public int StockAmount { get; set; }
        public List<ImageViewModel> Images { get; set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime UpdatedDate { get; private set; }
        public bool IsActive { get; private set; }
    }
}
