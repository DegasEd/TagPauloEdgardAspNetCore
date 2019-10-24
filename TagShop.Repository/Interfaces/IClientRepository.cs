using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;

namespace TagShop.Repository.Interfaces
{
    public interface IClientRepository : IRepositoryBase<Client>
    {
        Client Insert(Client obj);
        Client Update(Client obj);
        Client ChangeStatus(Guid obj);
        List<Client> GetAll();
        Client GetById(Guid key);
    }
}
