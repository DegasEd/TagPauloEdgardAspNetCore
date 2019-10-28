using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TagShop.Api.ViewModels.SalesItem;
using TagShop.Domain.Models;
using TagShop.Services.Interfaces;

namespace TagShop.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SaleItemController : BaseController
    {
        private readonly ISaleItemServices _saleitemServices;
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="saleitemServices"></param>
        /// <param name="mapper"></param>
        public SaleItemController(ISaleItemServices saleitemServices, IMapper mapper)
        {
            _saleitemServices = saleitemServices;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<SaleItemViewModel>> GetAll()
        {
            var resultService = _saleitemServices.GetAll();


            return _mapper.Map<List<SaleItemViewModel>>(resultService);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="saleitem"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<SaleItemViewModel> Post(CreateSaleItemViewModel saleitem)
        {
            var resultService = _saleitemServices.Insert(_mapper.Map<SaleItem>(saleitem));

            return _mapper.Map<SaleItemViewModel>(resultService);

        }

    }
}
