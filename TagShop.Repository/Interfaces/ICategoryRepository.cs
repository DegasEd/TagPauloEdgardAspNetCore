using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Repository.Interfaces
{
    public interface ICategoryRepository 
    {
        Category Insert(Category obj);
        Category Update(Category obj);
        Category ChangeStatus(Category obj);
        List<Category> GetAll();
        List<Category> GetById(int id);
               
    }
}
