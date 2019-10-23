using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TagShop.Domain.Models;
using TagShop.Repository.Interfaces;

namespace TagShop.Repository
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        private readonly IRepositoryBase<Category> _repositoryBaseCategory;

        public CategoryRepository(IConnectionFactory connectionFactory, IConfiguration configuration, ILogger<RepositoryBase<Category>> logger) : base(connectionFactory, configuration, logger)
        {
        }

 
        public Category ChangeStatus(Category obj)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Key",         obj.Key,      DbType.Guid);
            parameters.Add("@IsActive",    obj.IsActive, DbType.Boolean);
            parameters.Add("@UpdatedDate", obj.UpdatedDate, DbType.DateTime);


            var query = "UPDATE public.category SET  " +
                        "is_active = @IsActive,      " +
                        "updated_date = @UpdatedDate " +
                        "WHERE key = @Key            " ;

            var result = _repositoryBaseCategory.Insert(query, parameters);

            return result;
        }

        public List<Category> GetAll()
        {
            var query = "SELECT * FROM public.category ";

            var result = _repositoryBaseCategory.GetAll(query);

            return result;
        }

        public List<Category> GetById(Guid key)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Key", key, DbType.Guid);

            var query = "SELECT * FROM public.category    "+
                        "WHERE  key = @Key ";

            var result = _repositoryBaseCategory.GetAll(query, parameters);

            return result;
        }

        public Category Insert(Category obj)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Key",         obj.Key,         DbType.Guid);
            parameters.Add("@Description", obj.Description, DbType.String);
            parameters.Add("@IsActive",    obj.IsActive,    DbType.Boolean);
            parameters.Add("@CreatedDate", obj.CreatedDate, DbType.DateTime);
            parameters.Add("@UpdatedDate", obj.UpdatedDate, DbType.DateTime);


            var query = "INSERT INTO public.category(key, description, is_active, created_date, updated_date) " +
                        "VALUES (@Key, @Description, @IsActive, @CreatedDate, @UpdatedDate);";

            var result = _repositoryBaseCategory.Insert(query, parameters);

            return result;
        }

        public Category Update(Category obj)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Key",         obj.Key,         DbType.Guid);
            parameters.Add("@Description", obj.Description, DbType.String);
            parameters.Add("@UpdatedDate", obj.UpdatedDate, DbType.DateTime);


            var query = "UPDATE public.category SET      "+
                        "description = @Description,     "+
                        "updated_date = @UpdatedDate     "+
                        "WHERE key = @Key ";

            var result = _repositoryBaseCategory.Insert(query, parameters);

            return result;
        }
    }
}
