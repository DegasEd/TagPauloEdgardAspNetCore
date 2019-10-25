using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TagShop.Business.Interfaces;
using TagShop.Domain.Models;
using TagShop.Services.Interfaces;

namespace TagShop.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IProductBusiness _productBusiness;

        public ProductServices(IProductBusiness productBusiness)
        {
            _productBusiness = productBusiness;
        }

        public Product ChangePrice(Product obj, long newprice)
        {
            return _productBusiness.ChangePrice(obj, newprice);
        }

        public Product ChangeStatus(Product obj)
        {
            return _productBusiness.ChangeStatus(obj);
        }

        public Product DecreaseStock(Product obj, int subtract)
        {
            return _productBusiness.DecreaseStock(obj, subtract);
        }


        public List<Product> GetByKey(Guid categorykey, Guid productkey)
        {
            if (categorykey != Guid.Empty)
            {
                return _productBusiness.GetByCategoryKey(categorykey);
            }
            else if(productkey != Guid.Empty)
            {

                return _productBusiness.GetById(productkey);
            }
            else
            {
                return _productBusiness.GetAll();
            }
            
        }

    
        public Product IncreaseStock(Product obj, int add)
        {
            return _productBusiness.IncreaseStock(obj, add);
        }

        public Product Insert(Product obj)
        {
            return _productBusiness.Insert(obj);
        }

        public Product Update(Product obj)
        {
            return _productBusiness.Update(obj);
        }
    }
}
