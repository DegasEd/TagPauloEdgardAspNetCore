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
    public class SaleRepository : RepositoryBase<Sale>, ISaleRepository
    {
        public SaleRepository(IConnectionFactory connectionFactory, IConfiguration configuration, ILogger<RepositoryBase<Sale>> logger) : base(connectionFactory, configuration, logger)
        {

        }

        public Sale ChangeStatus(Sale obj)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Key", obj.Key, DbType.Guid);
            parameters.Add("@IsActive", obj.IsActive, DbType.Boolean);
            parameters.Add("@UpdatedDate", obj.UpdatedDate, DbType.DateTime);


            var query = "UPDATE public.sale SET  " +
                        "is_active = @IsActive,      " +
                        "updated_date = @UpdatedDate " +
                        "WHERE key = @Key    RETURNING *; ";

            return ChangeStatus(query, parameters);
        }

        public List<Sale> GetAll()
        {
            var query = "SELECT * FROM public.sale ";

            var result = GetAll(query);

            return result;
        }

        public List<Sale> GetById(Guid key)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Key", key, DbType.Guid);


            var query = "SELECT * FROM public.sale    " +
                        "WHERE  key = @Key ";

            var result = GetAll(query, parameters);

            return result;
        }

        public Sale Insert(Sale obj)
        {
            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@Key", obj.Key, DbType.Guid);
            parameter.Add("@CreatedDate", obj.CreatedDate, DbType.DateTime);
            parameter.Add("@UpdatedDate", obj.UpdatedDate, DbType.DateTime);
            parameter.Add("@IsActive", obj.IsActive, DbType.Boolean);
            parameter.Add("@ClientId", obj.ClientId, DbType.Int64);
            parameter.Add("@SaleDate", obj.SaleDate, DbType.DateTime);
            parameter.Add("@TotalPurchase", obj.TotalPurchase, DbType.Int64);
            parameter.Add("@Icms", obj.Icms, DbType.Int64);
            parameter.Add("@Pis", obj.Pis, DbType.Int64);
            parameter.Add("@Cofins", obj.Cofins, DbType.Int64);

            var query = @"INSERT INTO public.sale " +
                         "       ( key, created_date, updated_date, is_active, client_id, sale_date, total_purchase, icms,  pis,  cofins)  " +
                         "VALUES (@Key, @CreatedDate, @UpdatedDate, @IsActive, @ClientId, @SaleDate, @TotalPurchase, @Icms, @Pis, @Cofins) RETURNING *; ";
            
            return Insert(query, parameter);
        }

       
    }
}
