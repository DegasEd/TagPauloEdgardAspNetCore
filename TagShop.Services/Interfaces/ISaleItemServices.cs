using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Services.Interfaces
{
    public interface ISaleItemServices
    {
        SaleItem Insert(SaleItem obj);
        List<SaleItem> GetAll();
    }
}
