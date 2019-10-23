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
        T Insert(T obj, string query);
        T Update(T obj, string query);
        T ChangeStatus(T obj, string query); 
        #endregion

        List<T> GetAll(string query, DynamicParameters parameters);


    }
}
