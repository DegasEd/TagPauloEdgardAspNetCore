using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Services.Interfaces
{
    public interface IProductServices
    {
        Product Insert(Product obj);
        Product Update(Product obj);
        Product ChangeStatus(Product obj);
        List<Product> GetByKey(Guid categorykey, Guid productkey);
        Product IncreaseStock(Product obj, int add);
        Product DecreaseStock(Product obj, int subtract);
        Product ChangePrice(Product obj, long newprice);
    }
}
