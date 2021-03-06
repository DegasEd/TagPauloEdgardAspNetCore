﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagShop.Api.ViewModels
{
    public class ImageViewModel
    {
        public long Id { get; protected set; }
        public Guid Key { get; private set; }
        public string ImageId { get; set; }
        public byte[] Photo { get; set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime UpdatedDate { get; private set; }
        public bool IsActive { get; private set; }
    }
}
