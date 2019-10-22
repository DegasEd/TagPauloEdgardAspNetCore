﻿using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;
using TagShop.Repository.Interfaces;

namespace TagShop.Repository
{
    public class CategoryRepository
    {
        private readonly IRepositoryBase<Category> _repositoryBaseCategory;

        public CategoryRepository(IRepositoryBase<Category> repositoryBaseCategory)
        {
            _repositoryBaseCategory = repositoryBaseCategory;
        }

        public Category ChangeStatus(Category obj)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Category Insert(Category obj)
        {
            var query = string.Format("INSERT INTO public.category(category_id, description, is_active, created_date, updated_date) " +
                                      "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');",
                                        obj.CategoryId, obj.Description, obj.IsActive, obj.CreatedDate, obj.UpdatedDate
                                     );

            var result = _repositoryBaseCategory.Insert(obj, query);

            return result;
        }

        public Category Update(Category obj)
        {
            throw new NotImplementedException();
        }
    }
}
