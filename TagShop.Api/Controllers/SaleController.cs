using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TagShop.Api.ViewModels.Sales;
using TagShop.Domain.Models;
using TagShop.Services.Interfaces;

namespace TagShop.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : BaseController
    {
        private readonly ISaleServices _saleServices;
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="saleServices"></param>
        /// <param name="mapper"></param>
        public SaleController(ISaleServices saleServices, IMapper mapper)
        {
            _saleServices = saleServices;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<SaleViewModel>> GetAll()
        {
            var resultService = _saleServices.GetAll();


            return _mapper.Map<List<SaleViewModel>>(resultService);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("{key}")]
        public ActionResult<SaleViewModel> GetById(Guid key)
        {
            var resultService = _saleServices.GetById(key);


            return _mapper.Map<SaleViewModel>(resultService);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sale"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<SaleViewModel> Post(CreateSaleViewModel sale)
        {
            var resultService = _saleServices.Insert(_mapper.Map<Sale>(sale));

            return _mapper.Map<SaleViewModel>(resultService);

        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sale"></param>
        /// <returns></returns>
        [Route("changestatus")]
        [HttpPut]
        public ActionResult<SaleViewModel> ChangeStatus(Guid key)
        {
            var resultService = _saleServices.ChangeStatus(key);

            return _mapper.Map<SaleViewModel>(resultService);
        }


    }
}
