using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Repository.Interfaces
{
    public interface ISaleRepository : IRepositoryBase<Sale>
    {
        Sale Insert(Sale obj);
        Sale ChangeStatus(Sale obj);
        List<Sale> GetAll();
        List<Sale> GetById(Guid key);
    }
}
