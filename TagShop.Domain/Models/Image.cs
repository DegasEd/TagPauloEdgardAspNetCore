using System;
using System.Collections.Generic;
using System.Text;

namespace TagShop.Domain.Models
{
    public class Image : Entity
    {
        
        public string ImageId { get; set; }
        public byte[] Photo { get; set; }
    }
}
