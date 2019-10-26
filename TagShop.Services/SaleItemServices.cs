using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Business.Interfaces;
using TagShop.Domain.Models;
using TagShop.Services.Interfaces;

namespace TagShop.Services
{
    class SaleItemServices : ISaleItemServices
    {
        private readonly ISaleItemBusiness _saleitemBusiness;

        public SaleItemServices(ISaleItemBusiness saleitemBusiness)
        {
            _saleitemBusiness = saleitemBusiness;
        }

        public List<SaleItem> GetAll()
        {
            return _saleitemBusiness.GetAll();
        }

        public SaleItem Insert(SaleItem obj)
        {
            return _saleitemBusiness.Insert(obj);
        }
    }
}
