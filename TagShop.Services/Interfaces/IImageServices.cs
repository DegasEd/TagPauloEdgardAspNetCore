using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Services.Interfaces
{
    public interface IImageServices
    {
        Image Insert(Image obj);
        List<Image> GetAll();
    }
}
