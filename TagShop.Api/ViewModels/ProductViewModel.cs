using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TagShop.Api.ViewModels.Categories;

namespace TagShop.Api.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            Category = new ResultCategoryViewModel();
            Images = new List<ImageViewModel>();
        }

        public long Id { get; protected set; }
        public Guid Key { get; private set; }
        public string ProductId { get; set; }
        public ResultCategoryViewModel Category { get; set; }
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
