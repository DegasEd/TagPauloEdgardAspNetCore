using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TagShop.Domain.Abstract;
using TagShop.Repository.Interfaces;


namespace TagShop.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity
    {
        private readonly IConnectionFactory _connectionFactory;

        private readonly IConfiguration _configuration;

        protected readonly NpgsqlConnection Conn;

        protected readonly ILogger<RepositoryBase<T>> _logger;

        public RepositoryBase(IConnectionFactory connectionFactory, IConfiguration configuration, ILogger<RepositoryBase<T>> logger)
        {
            _connectionFactory = connectionFactory;
            _configuration = configuration;
            _logger = logger;
            Conn = _connectionFactory.GetConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        public T ChangeStatus(string query, DynamicParameters parameters)
        {
            return Conn.Query<T>(query, parameters).ToList().FirstOrDefault();            
        }

        public List<T> GetAll(string query, DynamicParameters parameters = null)
        {
            try
            {
                if (parameters == null)
                    return Conn.Query<T>(query).ToList();

                return Conn.Query<T>(query, parameters).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

         public T Insert(string query, DynamicParameters parameters)
        {
            var varDoPaulo = Conn.Query<T>(query, parameters).ToList().FirstOrDefault();

            return varDoPaulo;
        }

        public T Update(string query, DynamicParameters parameters)
        {
            return Conn.Query<T>(query, parameters).ToList().FirstOrDefault();
        }

        public void Dispose()
        {
            Conn.Close();
            Conn.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
