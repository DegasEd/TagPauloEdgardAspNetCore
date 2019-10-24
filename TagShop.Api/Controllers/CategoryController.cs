using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TagShop.Api.ViewModels;
using TagShop.Domain.Models;
using TagShop.Services.Interfaces;


namespace TagShop.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    
    public class CategoryController : BaseController
    {
        private readonly ICategoryServices _categoryServices;
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryServices"></param>
        public CategoryController(ICategoryServices categoryServices, IMapper mapper)
        {
            _categoryServices = categoryServices;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<ResultCategoryViewModel>> GetAll()
        {
            var resultService = _categoryServices.GetAll();

            
            return _mapper.Map<List<ResultCategoryViewModel>>(resultService);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpGet("{key}")]
        public ActionResult<ResultCategoryViewModel> Get(Guid key)
        {
            var resultService = _categoryServices.GetById(key);

            return _mapper.Map<ResultCategoryViewModel>(resultService);
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="category"></param>
       /// <returns></returns>
        [HttpPost]
        public ActionResult<ResultCategoryViewModel> Post(CreateCategoryViewModel category)
        {
            var resultService = _categoryServices.Insert(_mapper.Map<Category>(category));

            return _mapper.Map<ResultCategoryViewModel>(resultService);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [Route("update")]
        [HttpPut]
        public ActionResult<ResultCategoryViewModel> Put(CreateCategoryViewModel category)
        {
            var resultService = _categoryServices.Update(_mapper.Map<Category>(category));

            return _mapper.Map<ResultCategoryViewModel>(resultService);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [Route("changestatus")]
        [HttpPut]
        public ActionResult<ResultCategoryViewModel> ChangeStatus(ResultCategoryViewModel category)
        {
            var resultService = _categoryServices.ChangeStatus(_mapper.Map<Category>(category));

            return _mapper.Map<ResultCategoryViewModel>(resultService);
        }


    }
}
