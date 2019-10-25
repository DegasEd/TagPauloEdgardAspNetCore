using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Business.Interfaces
{
    public interface ICategoryBusiness
    {
        Category Insert(Category obj);
        Category Update(Category obj);
        Category ChangeStatus(Category obj);
        List<Category> GetAll();
        List<Category> GetById(Guid key);


    }
}
