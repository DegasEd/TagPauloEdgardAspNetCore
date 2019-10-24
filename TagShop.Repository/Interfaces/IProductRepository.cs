using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Repository.Interfaces
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        Product Insert(Product obj);
        Product Update(Product obj);
        Product ChangeStatus(Product obj);
        List<Product> GetAll();
        List<Product> GetById(Guid key);
        List<Product> GetByCategoryKey(Guid key);

        Product ChangeStock(Product obj);
        Product ChangePrice(Product obj);
    }
}
