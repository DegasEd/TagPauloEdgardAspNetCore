using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TagShop.Domain.Models;
using TagShop.Repository.Interfaces;


namespace TagShop.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : Entity
    {
        private readonly IConfiguration _configuration;

        public RepositoryBase(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected IDbConnection Conn => new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection"));

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

        public T Insert(T obj, string query)
        {


            throw new NotImplementedException();
        }

        public T Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
