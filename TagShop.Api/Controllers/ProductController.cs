using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TagShop.Api.ViewModels.Products;
using TagShop.Domain.Models;
using TagShop.Services.Interfaces;

namespace TagShop.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController
    {
        private readonly IProductServices _productServices;
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productServices"></param>
        /// <param name="mapper"></param>
        public ProductController(IProductServices productServices, IMapper mapper)
        {
            _productServices = productServices;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<ProductViewModel>> GetByKey(Guid categorykey, Guid productkey)
        {
            var resultService = _productServices.GetByKey(categorykey, productkey);


            return _mapper.Map<List<ProductViewModel>>(resultService);
        }
                
        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<ProductViewModel> Post(CreateProductViewModel product)
        {
            var resultService = _productServices.Insert(_mapper.Map<Product>(product));

            return _mapper.Map<ProductViewModel>(resultService);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [Route("update")]
        [HttpPut]
        public ActionResult<ProductViewModel> Put(ProductViewModel product)
        {
            var resultService = _productServices.Update(_mapper.Map<Product>(product));

            return _mapper.Map<ProductViewModel>(resultService);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [Route("changestatus")]
        [HttpPut]
        public ActionResult<ProductViewModel> ChangeStatus(ProductViewModel product)
        {
            var resultService = _productServices.ChangeStatus(_mapper.Map<Product>(product));

            return _mapper.Map<ProductViewModel>(resultService);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <param name="newprice"></param>
        /// <returns></returns>
        [Route("changeprice")]
        [HttpPut]
        public ActionResult<ProductViewModel> ChangePrice(ProductViewModel product, long newprice)
        {
            var resultService = _productServices.ChangePrice(_mapper.Map<Product>(product), newprice);

            return _mapper.Map<ProductViewModel>(resultService);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <param name="addstock"></param>
        /// <returns></returns>
        [Route("addstock")]
        [HttpPut]
        public ActionResult<ProductViewModel> IncreaseStock(ProductViewModel product, int addstock)
        {
            var resultService = _productServices.IncreaseStock(_mapper.Map<Product>(product), addstock);

            return _mapper.Map<ProductViewModel>(resultService);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <param name="subtractstock"></param>
        /// <returns></returns>
        [Route("subtractstock")]
        [HttpPut]
        public ActionResult<ProductViewModel> DecreaseStock(ProductViewModel product, int subtractstock)
        {
            var resultService = _productServices.DecreaseStock(_mapper.Map<Product>(product), subtractstock);

            return _mapper.Map<ProductViewModel>(resultService);
        }

    }
}
