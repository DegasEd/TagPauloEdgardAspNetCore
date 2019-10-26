using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagShop.Api.ViewModels.Images
{
    public class CreateImageViewModel
    {
        public long ProductId { get; set; }
        public byte[] Photo { get; set; }
        }
}
