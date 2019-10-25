using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TagShop.Domain.Models;
using TagShop.Business.Interfaces;
using TagShop.Services.Interfaces;

namespace TagShop.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly ICategoryBusiness _categoryBusiness;
        
        public CategoryServices(ICategoryBusiness categoryBusiness)
        {
            _categoryBusiness = categoryBusiness;
        }

        public Category ChangeStatus(Category obj)
        {
            return _categoryBusiness.ChangeStatus(obj);
        }

        public List<Category> GetAll()
        {
            return _categoryBusiness.GetAll();
        }

        public Category GetById(Guid key)
        {
            return _categoryBusiness.GetById(key).ToList().FirstOrDefault(); 
        }

        public Category Insert(Category obj)
        {
            return _categoryBusiness.Insert(obj);
        }

        public Category Update(Category obj)
        {
            return _categoryBusiness.Update(obj);
        }
    }
}
