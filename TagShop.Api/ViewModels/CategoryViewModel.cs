using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagShop.Api.ViewModels
{
    public class CategoryViewModel
    {
        public long Id { get; protected set; }
        public Guid Key { get; private set; }
        public string CategoryId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime UpdatedDate { get; private set; }
        public bool IsActive { get; private set; }

    }
}
