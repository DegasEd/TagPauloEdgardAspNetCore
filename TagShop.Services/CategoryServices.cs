using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TagShop.Domain.Models;
using TagShop.Repository.Interfaces;
using TagShop.Services.Interfaces;

namespace TagShop.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryServices(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category ChangeStatus(Category obj)
        {
            return _categoryRepository.ChangeStatus(obj);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(Guid key)
        {
            return _categoryRepository.GetById(key).ToList().FirstOrDefault(); 
        }

        public Category Insert(Category obj)
        {
            return _categoryRepository.Insert(obj);
        }

        public Category Update(Category obj)
        {
            return _categoryRepository.Update(obj);
        }
    }
}
