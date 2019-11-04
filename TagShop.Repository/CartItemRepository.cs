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
    public class CartItemRepository : RepositoryBase<CartItem>, ICartItemRepository
    {
        public CartItemRepository(IConnectionFactory connectionFactory, IConfiguration configuration, ILogger<RepositoryBase<CartItem>> logger) : base(connectionFactory, configuration, logger)
        {

        }
        public CartItem ChangeStatus(Guid key)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Key", key, DbType.Guid);
            parameters.Add("@IsActive", false, DbType.Boolean);
            parameters.Add("@UpdatedDate", DateTime.Now, DbType.DateTime);


            var query = "UPDATE public.cart_item SET  " +
                        "is_active = @IsActive,      " +
                        "updated_date = @UpdatedDate " +
                        "WHERE key = @Key    RETURNING *; ";

            return ChangeStatus(query, parameters);
        }

        public List<CartItem> GetAll()
        {
            var query = "SELECT * FROM public.cart_item ";

            var result = GetAll(query);

            return result;
        }

        public List<CartItem> GetByCart(Int64 cartId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@cartId", cartId, DbType.Guid);


            var query = "SELECT * FROM public.cart_item WHERE  cart_id = @cartId ";

            var result = GetAll(query, parameters);

            return result;
        }

        public List<CartItem> GetById(Guid key)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Key", key, DbType.Guid);


            var query = "SELECT * FROM public.cart_item WHERE  key = @Key ";

            var result = GetAll(query, parameters);

            return result;
        }

        public CartItem Insert(CartItem obj)
        {
            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@Key", obj.Key, DbType.Guid);
            parameter.Add("@CreatedDate", obj.CreatedDate, DbType.DateTime);
            parameter.Add("@UpdatedDate", obj.UpdatedDate, DbType.DateTime);
            parameter.Add("@IsActive", obj.IsActive, DbType.Boolean);
            parameter.Add("@CartId", obj.CartId, DbType.Int64);
            parameter.Add("@ProductId", obj.Product.Id, DbType.Int64);
            parameter.Add("@Amount", obj.Amount, DbType.Int64);
            


            var query = new StringBuilder();
            query.Append("INSERT INTO public.cart( ");
            query.Append("key, created_date, updated_date, ");
            query.Append("is_active, cart_id, product_id, amount) VALUES ( ");
            query.Append("@Key, @CreatedDate, @UpdatedDate, @IsActive, @CartId, @ProductId, @Amount) RETURNING * ");


            return Insert(query.ToString(), parameter);
        }
    }
}
