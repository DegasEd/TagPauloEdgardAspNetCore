using System;
using System.Collections.Generic;
using System.Text;

namespace TagShop.Domain.Models
{
    public class Category : Entity
    {
        
        public string CategoryId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
