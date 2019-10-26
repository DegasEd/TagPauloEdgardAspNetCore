﻿using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Repository.Interfaces
{
    public interface ISaleItemRepository : IRepositoryBase<SaleItem>
    {
        SaleItem Insert(SaleItem obj);
        List<SaleItem> GetAll();
    }
}
