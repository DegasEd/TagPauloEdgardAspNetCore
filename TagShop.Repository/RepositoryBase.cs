using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Abstract;
using TagShop.Repository.Interfaces;
using System.Data.SqlClient;
using System.Linq;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System.IO;
using Npgsql;

namespace TagShop.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity
    {
        private readonly IConnectionFactory _connectionFactory;
        private readonly IConfiguration _configuration;

        protected readonly NpgsqlConnection conn;

        public RepositoryBase(IConnectionFactory connectionFactory, IConfiguration configuration)
        {
            _connectionFactory = connectionFactory;
            _configuration = configuration;

            conn = _connectionFactory.GetConnection(_configuration.GetConnectionString("DefaultConnection"));
            conn.Open();
        }

        public T ChangeStatus(T obj)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public T Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
