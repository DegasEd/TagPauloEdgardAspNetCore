using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Business.Interfaces;
using TagShop.Domain.Models;
using TagShop.Repository.Interfaces;

namespace TagShop.Business
{
    public class CategoryBusiness : ICategoryBusiness
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryBusiness(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category Insert(Category obj)
        {
            return _categoryRepository.Insert(obj);
            
        }

        public Category Update(Category obj)
        {
            obj.SetUpdateDate();

            return _categoryRepository.Update(obj);

        }

        public Category ChangeStatus(Category obj)
        {
            obj.ChangeStatus();
            obj.SetUpdateDate();

            return _categoryRepository.ChangeStatus(obj);

        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();

        }

        public List<Category> GetById(Guid key)
        {
            return _categoryRepository.GetById(key);

        }

    }
}
