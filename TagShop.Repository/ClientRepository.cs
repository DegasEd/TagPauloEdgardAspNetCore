using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TagShop.Domain.Models;
using TagShop.Repository.Interfaces;

namespace TagShop.Repository
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(IConnectionFactory connectionFactory, IConfiguration configuration, ILogger<RepositoryBase<Client>> logger) : base(connectionFactory, configuration, logger)
        {

        }

        public Client ChangeStatus(Guid key)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Key", key, DbType.Guid);
            parameters.Add("@IsActive", false, DbType.Boolean);
            parameters.Add("@UpdatedDate", DateTime.Now, DbType.DateTime);

            var query = new StringBuilder();
            query.Append("UPDATE public.client SET ");
            query.Append("is_active = @IsActive, ");
            query.Append("updated_date = @UpdatedDate ");
            query.Append("WHERE key = @Key    RETURNING *; ");

            return ChangeStatus(query.ToString(), parameters);
        }

        public List<Client> GetAll()
        {
            var query = "SELECT * FROM public.client ";

            var result = GetAll(query);

            return result;
        }

        public Client GetById(Guid key)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Key", key, DbType.Guid);


            var query = "SELECT * FROM public.client WHERE  key = @Key RETURNING *";

            var result = GetAll(query, parameters).ToList().FirstOrDefault();

            return result;
        }

        public Client Insert(Client obj)
        {
            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@Key", obj.Key, DbType.Guid);
            parameter.Add("@CreatedDate", obj.CreatedDate, DbType.DateTime);
            parameter.Add("@UpdatedDate", obj.UpdatedDate, DbType.DateTime);
            parameter.Add("@IsActive", obj.IsActive, DbType.Boolean);
            parameter.Add("@cpf", obj.Cpf, DbType.String);
            parameter.Add("@birth_date", obj.BirthDate, DbType.DateTime);
            parameter.Add("@email", obj.Email, DbType.String);
            parameter.Add("@hash", obj.Password, DbType.String);
            parameter.Add("@address", obj.Address, DbType.String);
            parameter.Add("@city", obj.City, DbType.String);
            parameter.Add("@state", obj.State, DbType.String);
            parameter.Add("@zip_code", obj.ZipCode, DbType.String);
            parameter.Add("@phone", obj.Phone, DbType.String);
            parameter.Add("@name", obj.Name, DbType.String);


            var query = new StringBuilder();
            query.Append("INSERT INTO public.client( ");
            query.Append("key, created_date, updated_date, ");
            query.Append("is_active, cpf, birth_date, email, ");
            query.Append("hash, address, city, state, zip_code, ");
            query.Append("phone, name) VALUES (");
            query.Append("@Key, @CreatedDate, @UpdatedDate, @IsActive, ");
            query.Append("@cpf, @birth_date, @email, @hash, @address, ");
            query.Append("@city, @state, @zip_code, @phone, @name) RETURNING *");


            return Insert(query.ToString(), parameter);
        }

        public Client Update(Client obj)
        {
            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@Key", obj.Key, DbType.Guid);
            parameter.Add("@cpf", obj.Cpf, DbType.String);
            parameter.Add("@birth_date", obj.BirthDate, DbType.DateTime);
            parameter.Add("@email", obj.Email, DbType.String);
            parameter.Add("@hash", obj.Password, DbType.String);
            parameter.Add("@address", obj.Address, DbType.String);
            parameter.Add("@city", obj.City, DbType.String);
            parameter.Add("@state", obj.State, DbType.String);
            parameter.Add("@zip_code", obj.ZipCode, DbType.String);
            parameter.Add("@phone", obj.Phone, DbType.String);
            parameter.Add("@name", obj.Name, DbType.String);

            var query = new StringBuilder();
            query.Append("UPDATE public.client set ");
            query.Append("cpf = @cpf, birth_date = @birth_date, email = @email, ");
            query.Append("hash = @hash, address = @address, city = @city, ");
            query.Append("state = @state, zip_code = @zip_code, phone = @phone, name = @name ");
            query.Append("where key = @key RETURNING *");

            return Insert(query.ToString(), parameter);
        }
    }
}
