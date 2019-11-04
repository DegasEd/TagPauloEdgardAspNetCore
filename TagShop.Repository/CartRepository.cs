using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;
using TagShop.Repository.Interfaces;
using System.Data;

namespace TagShop.Repository
{
    public class CartRepository :  RepositoryBase<Cart>, ICartRepository
    {
        public CartRepository(IConnectionFactory connectionFactory, IConfiguration configuration, ILogger<RepositoryBase<Cart>> logger) : base(connectionFactory, configuration, logger)
        {

        }

        public Cart ChangeStatus(Guid key)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Key", key, DbType.Guid);
            parameters.Add("@IsActive", false, DbType.Boolean);
            parameters.Add("@UpdatedDate", DateTime.Now, DbType.DateTime);


            var query = "UPDATE public.cart SET  " +
                        "is_active = @IsActive,      " +
                        "updated_date = @UpdatedDate " +
                        "WHERE key = @Key    RETURNING *; ";

            return ChangeStatus(query, parameters);
        }

        public List<Cart> GetAll()
        {
            var query = "SELECT * FROM public.cart ";

            var result = GetAll(query);

            return result;
        }

        public List<Cart> GetById(Guid key)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Key", key, DbType.Guid);


            var query = "SELECT * FROM public.cart WHERE  key = @Key ";

            var result = GetAll(query, parameters);

            return result;
        }

        public Cart Insert(Cart obj)
        {
            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@Key", obj.Key, DbType.Guid);
            parameter.Add("@CreatedDate", obj.CreatedDate, DbType.DateTime);
            parameter.Add("@UpdatedDate", obj.UpdatedDate, DbType.DateTime);
            parameter.Add("@IsActive", obj.IsActive, DbType.Boolean);
            parameter.Add("@ClientId", obj.ClientId, DbType.Int64);


            var query = new StringBuilder();
            query.Append("INSERT INTO public.cart( ");
            query.Append("key, created_date, updated_date, ");
            query.Append("is_active, client_id) VALUES ( ");
            query.Append("@Key, @CreatedDate, @UpdatedDate, @IsActive, @ClientId) RETURNING * ");


            return Insert(query.ToString(), parameter);
        }
    }
}
