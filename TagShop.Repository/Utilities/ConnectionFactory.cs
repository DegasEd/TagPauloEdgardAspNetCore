using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using TagShop.Repository.Interfaces;

namespace TagShop.Repository.Utilities
{
    public class ConnectionFactory : IConnectionFactory
    {
        public NpgsqlConnection GetConnection(string connectionString)
        {
            var conn = new NpgsqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}