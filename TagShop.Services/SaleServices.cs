using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TagShop.Business.Interfaces;
using TagShop.Domain.Models;
using TagShop.Services.Interfaces;

namespace TagShop.Services
{
    public class SaleServices : ISaleServices
    {
        private readonly ISaleBusiness _saleBusiness;

        public SaleServices(ISaleBusiness saleBusiness)
        {
            _saleBusiness = saleBusiness;
        }

        public Sale ChangeStatus(Guid key)
        {
            return _saleBusiness.ChangeStatus(key);
        }

        public List<Sale> GetAll()
        {
            return _saleBusiness.GetAll();
        }

        public Sale GetById(Guid key)
        {
            return _saleBusiness.GetById(key).ToList().FirstOrDefault();
        }

        public Sale Insert(Sale obj)
        {
            return _saleBusiness.Insert(obj);
        }
    }
}
