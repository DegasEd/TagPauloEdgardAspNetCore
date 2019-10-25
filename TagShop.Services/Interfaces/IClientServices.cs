using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Services.Interfaces
{
    public interface IClientServices
    {
        Client Insert(Client obj);
        Client Update(Client obj);
        Client ChangeStatus(Guid key);
        List<Client> GetAll();
        Client GetById(Guid key);
    }
}
