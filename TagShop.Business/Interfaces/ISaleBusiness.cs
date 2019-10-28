using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Business.Interfaces
{
    public interface ISaleBusiness
    {
        Sale Insert(Sale obj);
        Sale ChangeStatus(Guid key);
        List<Sale> GetAll();
        List<Sale> GetById(Guid key);
    }
}
