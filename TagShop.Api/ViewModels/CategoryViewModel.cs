using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagShop.Api.ViewModels
{
    public class CategoryViewModel
    {
        public long Id { get;  set; }
        public Guid Key { get; set; }
        public string CategoryId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get;  set; }
        public DateTime UpdatedDate { get;  set; }
        public bool IsActive { get;  set; }

    }
}
