using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Abstract;

namespace TagShop.Domain.Models
{
    public class Image : BaseEntity
    {
        
        public string ImageId { get; set; }
        public byte[] Photo { get; set; }
    }
}
