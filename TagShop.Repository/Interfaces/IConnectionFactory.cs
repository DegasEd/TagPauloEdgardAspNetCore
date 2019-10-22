using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace TagShop.Repository.Interfaces
{
    public interface IConnectionFactory
    {
            NpgsqlConnection GetConnection(string connectionString);
    }
}
