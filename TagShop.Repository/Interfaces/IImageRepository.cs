using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Repository.Interfaces
{
    public interface IImageRepository : IRepositoryBase<Image>
    {
        Image Insert(Image obj);
        List<Image> GetAll();
    }
}
