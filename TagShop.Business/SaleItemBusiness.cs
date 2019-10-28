using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Business.Interfaces;
using TagShop.Domain.Models;
using TagShop.Repository.Interfaces;

namespace TagShop.Business
{
    public class SaleItemBusiness : ISaleItemBusiness
    {
        private readonly ISaleItemRepository _saleitemRepository;

        public SaleItemBusiness(ISaleItemRepository saleitemRepository)
        {
            _saleitemRepository = saleitemRepository;
        }
        public List<SaleItem> GetAll()
        {
            return _saleitemRepository.GetAll();
        }

        public SaleItem Insert(SaleItem obj)
        {
            return _saleitemRepository.Insert(obj);
        }
    }
}
