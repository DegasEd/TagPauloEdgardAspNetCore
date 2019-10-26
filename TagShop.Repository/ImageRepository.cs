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
    public class ImageRepository : RepositoryBase<Image>, IImageRepository
    {
        public ImageRepository(IConnectionFactory connectionFactory, IConfiguration configuration, ILogger<RepositoryBase<Image>> logger) : base(connectionFactory, configuration, logger)
        {

        }

        public List<Image> GetAll()
        {

            var query = "SELECT * FROM public.image ";

            var result = GetAll(query);

            return result;
        }

        public Image Insert(Image obj)
        {
            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@Key", obj.Key, DbType.Guid);
            parameter.Add("@CreatedDate", obj.CreatedDate, DbType.DateTime);
            parameter.Add("@UpdatedDate", obj.UpdatedDate, DbType.DateTime);
            parameter.Add("@IsActive", obj.IsActive, DbType.Boolean);
            parameter.Add("@ProductId", obj.ProductId, DbType.Int64);
            parameter.Add("@Photo", obj.Photo, DbType.Byte);
            

            var query = @"INSERT INTO public.image " +
                         "       ( key, created_date, updated_date, is_active, product_id,  photo)  " +
                         "VALUES (@Key, @CreatedDate, @UpdatedDate, @IsActive, @product_id, @photo) RETURNING *; ";

            return Insert(query, parameter);
        }
    }
}
