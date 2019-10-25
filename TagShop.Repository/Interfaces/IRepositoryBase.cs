using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Abstract;
using TagShop.Domain.Models;

namespace TagShop.Repository.Interfaces
{
    public interface IRepositoryBase<T> where T : BaseEntity
    {
        #region CRUD
        T Insert(string query, DynamicParameters parameters);
        T Update(string query, DynamicParameters parameter);
        T ChangeStatus(string query, DynamicParameters parameters); 
        #endregion

        List<T> GetAll(string query, DynamicParameters parameters = null);


    }
}
