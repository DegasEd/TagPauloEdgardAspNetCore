using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Business.Interfaces
{
    public interface IClientBusiness
    {
        Client Insert(Client obj);
        Client Update(Client obj);
        Client ChangeStatus(Guid key);
        List<Client> GetAll();
        Client GetById(Guid key);
    }
}
