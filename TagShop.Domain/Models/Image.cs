using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Abstract;

namespace TagShop.Domain.Models
{
    public class Image : BaseEntity
    {
        
        public string PoductId { get; set; }
        public byte[] Photo { get; set; }
    }
}
