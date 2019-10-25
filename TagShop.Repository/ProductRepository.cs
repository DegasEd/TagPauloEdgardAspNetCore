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
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        private readonly IRepositoryBase<Product> _repositoryBase;

        public ProductRepository(IConnectionFactory connectionFactory, IConfiguration configuration, ILogger<RepositoryBase<Product>> logger) : base(connectionFactory, configuration, logger)
        {
        }

        public Product ChangePrice(Product obj)
        {
            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@Key", obj.Key, DbType.Guid);
            parameter.Add("@Price", obj.Price, DbType.Int64);
            parameter.Add("@UpdatedDate", obj.UpdatedDate, DbType.DateTime);

            var query = @"UPDATE public.product SET       " +
                         "price        = @Price           " +
                         "updated_date = @UpdatedDate     " +
                         "WHERE key = @Key  RETURNING *;  " ;

            var result = Update(query, parameter);

            return result;
        }

        public Product ChangeStatus(Product obj)
        {
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@Key", obj.Key, DbType.Guid);
            parameter.Add("@IsActive", obj.IsActive, DbType.Boolean);
            parameter.Add("@UpdatedDate", obj.UpdatedDate, DbType.DateTime);


            var query = "UPDATE public.Product SET  " +
                        "is_active = @IsActive,      " +
                        "updated_date = @UpdatedDate " +
                        "WHERE key = @Key    RETURNING *; ";

            return ChangeStatus(query, parameter);
        }

        public List<Product> GetAll()
        {
            var query = "SELECT * FROM public.product ";

            var result = GetAll(query);

            return result;
        }

        public List<Product> GetByCategoryKey(Guid key)
        {
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@Key", key, DbType.Guid);

            var query = "SELECT product.* "+
                        "FROM   public.product   as product, " +
                        "       public.category  as category " +
                        "WHERE  product.category_id = category.id " +
                        "AND    category.key        = @Key ";

            var result = GetAll(query, parameter);

            return result;
        }

        public List<Product> GetById(Guid key)
        {
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@Key", key, DbType.Guid);

            var query = "SELECT product.*                  " +
                        "FROM   public.product  as product " +
                        "WHERE  product.key     = @Key     " ;

            var result = GetAll(query, parameter);

            return result;
        }

        public Product Insert(Product obj)
        {
            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@Key",         obj.Key,         DbType.Guid);
            parameter.Add("@Description", obj.Description, DbType.String);
            parameter.Add("@IsActive",    obj.IsActive,    DbType.Boolean);
            parameter.Add("@CreatedDate", obj.CreatedDate, DbType.DateTime);
            parameter.Add("@UpdatedDate", obj.UpdatedDate, DbType.DateTime);
            parameter.Add("@CategoryId",  obj.CategoryId,  DbType.Int64);
            parameter.Add("@Detail",      obj.Detail,      DbType.String);
            parameter.Add("@Price",       obj.Price,       DbType.Int64);
            parameter.Add("@StockAmount", obj.StockAmount, DbType.Int64);

            var query = @"INSERT INTO public.product(key, created_date, updated_date, is_active, category_id, description, detail, price, stock_amount) " +
                        "VALUES (@Key, @CreatedDate, @UpdatedDate, @IsActive, @CategoryId, @Description, @Detail, @Price, @StockAmount) RETURNING *; ";

            return Insert(query, parameter);
        }

        public Product ChangeStock(Product obj)
        {
            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@Key", obj.Key, DbType.Guid);
            parameter.Add("@StockAmount", obj.StockAmount, DbType.Int64);
            parameter.Add("@UpdatedDate", obj.UpdatedDate, DbType.DateTime);

            var query = @"UPDATE public.product SET       " +
                         "stock_amount = @StockAmount     " +
                         "updated_date = @UpdatedDate     " +
                         "WHERE key = @Key  RETURNING *;  " ;

            var result = Update(query, parameter);

            return result;
        }

        public Product Update(Product obj)
        {
            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@Key", obj.Key, DbType.Guid);
            parameter.Add("@Description", obj.Description, DbType.String);
            parameter.Add("@Detail", obj.Detail, DbType.String);
            parameter.Add("@UpdatedDate", obj.UpdatedDate, DbType.DateTime);


            var query = @"UPDATE public.product SET       " +
                         "description  = @Description,    " +
                         "detail       = @Detail          " +
                         "updated_date = @UpdatedDate     " +
                         "WHERE key = @Key  RETURNING *;  " ;

            var result = Update(query, parameter);

            return result;
        }
    }
}
