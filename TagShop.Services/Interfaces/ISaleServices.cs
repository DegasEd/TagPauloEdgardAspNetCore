using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Services.Interfaces
{
    public interface ISaleServices
    {
        Sale Insert(Sale obj);
        Sale ChangeStatus(Guid key);
        List<Sale> GetAll();
        Sale GetById(Guid key);
    }
}
