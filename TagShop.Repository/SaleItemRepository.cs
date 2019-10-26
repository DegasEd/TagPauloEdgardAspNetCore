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
    public class SaleItemRepository : RepositoryBase<SaleItem>, ISaleItemRepository
    {
        public SaleItemRepository(IConnectionFactory connectionFactory, IConfiguration configuration, ILogger<RepositoryBase<SaleItem>> logger) : base(connectionFactory, configuration, logger)
        {

        }

        public List<SaleItem> GetAll()
        {

            var query = "SELECT * FROM public.sale_item ";

            var result = GetAll(query);

            return result;
        }

        public SaleItem Insert(SaleItem obj)
        {
            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@Key", obj.Key, DbType.Guid);
            parameter.Add("@CreatedDate", obj.CreatedDate, DbType.DateTime);
            parameter.Add("@UpdatedDate", obj.UpdatedDate, DbType.DateTime);
            parameter.Add("@IsActive", obj.IsActive, DbType.Boolean);
            parameter.Add("@SaleId", obj.SaleId, DbType.Int64);
            parameter.Add("@ProductId", obj.ProductId, DbType.Int64);
            parameter.Add("@Amount", obj.Amount, DbType.Int64);
            parameter.Add("@UnitaryValue", obj.UnitaryValue, DbType.Int64);
            
            var query = @"INSERT INTO public.sale_item " +
                         "       ( key, created_date, updated_date, is_active, sale_id,  product_id,  amount,  unitary_value)  " +
                         "VALUES (@Key, @CreatedDate, @UpdatedDate, @IsActive, @sale_id, @product_id, @amount, @unitary_value) RETURNING *; ";

            return Insert(query, parameter);
        }
    }
}
