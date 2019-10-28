using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Business.Interfaces
{
    public interface ISaleItemBusiness
    {
        SaleItem Insert(SaleItem obj);
        List<SaleItem> GetAll();
    }
}
