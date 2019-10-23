using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Services.Interfaces
{
    public interface ICategoryServices
    {
        Category Insert(Category obj);
        Category Update(Category obj);
        Category ChangeStatus(Category obj);
        List<Category> GetAll();
        Category GetById(Guid key);
    }
}
