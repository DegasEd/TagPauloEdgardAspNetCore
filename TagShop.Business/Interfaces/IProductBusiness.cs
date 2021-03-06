﻿using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Business.Interfaces
{
    public interface IProductBusiness
    {
        Product Insert(Product obj);
        Product Update(Product obj);
        Product ChangeStatus(Product obj);
        List<Product> GetAll();
        List<Product> GetById(Guid key);
        List<Product> GetByCategoryKey(Guid key);

        Product IncreaseStock(Product obj, int add);
        Product DecreaseStock(Product obj, int subtract);
        Product ChangePrice(Product obj, long newprice);
    }
}
