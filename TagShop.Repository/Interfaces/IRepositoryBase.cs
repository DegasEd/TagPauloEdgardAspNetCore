using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Repository.Interfaces
{
    public interface IRepositoryBase<T> where T : Entity
    {
        #region CRUD
        T Insert(T obj);
        T Update(T obj);
        T ChangeStatus(T obj); 
        #endregion

        List<T> GetAll();
        T GetById(int id);

    }
}
