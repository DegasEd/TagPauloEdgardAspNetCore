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

        public Cart ChangeStatus(Cart obj)
        {
            throw new NotImplementedException();
        }

        public List<Cart> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Cart> GetById(Guid key)
        {
            throw new NotImplementedException();
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

        public Cart Update(Cart obj)
        {
            throw new NotImplementedException();
        }
    }
}
