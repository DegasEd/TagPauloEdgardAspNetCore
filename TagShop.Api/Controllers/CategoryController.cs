using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryServices"></param>
        public CategoryController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<CategoryViewModel>> GetAll()
        {
            var result = new List<CategoryViewModel>();

            var resultService = _categoryServices.GetAll();

            resultService.ForEach(c =>
            {
                result.Add(new CategoryViewModel()
                {
                    Id = c.Id,
                    Key = c.Key,
                    CreatedDate = c.CreatedDate,
                    Description = c.Description,
                    IsActive = c.IsActive,
                    UpdatedDate = c.UpdatedDate
                });
            });
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [HttpGet("{key}")]
        public ActionResult<CategoryViewModel> Get(Guid key)
        {
            var resultService = _categoryServices.GetById(key);

            return new CategoryViewModel()
            {
                Id = resultService.Id,
                Key = resultService.Key,
                CreatedDate = resultService.CreatedDate,
                Description = resultService.Description,
                IsActive = resultService.IsActive,                
                UpdatedDate = resultService.UpdatedDate
            };
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="category"></param>
       /// <returns></returns>
        [HttpPost]
        public ActionResult<CategoryViewModel> Post(CategoryViewModel category)
        {
            var resultService = _categoryServices.Insert(new Category()
            {
                Description = category.Description,
            });

            return new CategoryViewModel() 
            {
                Id = resultService.Id,
                Key = resultService.Key,
                CreatedDate = resultService.CreatedDate,
                Description = resultService.Description,
                IsActive = resultService.IsActive,
                UpdatedDate = resultService.UpdatedDate
            };

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [Route("update")]
        [HttpPut]
        public ActionResult<CategoryViewModel> Put(CategoryViewModel category)
        {
            var resultService = _categoryServices.Update(new Category()
            {
                Description = category.Description,
            });

            return new CategoryViewModel()
            {
                Id = resultService.Id,
                Key = resultService.Key,
                CreatedDate = resultService.CreatedDate,
                Description = resultService.Description,
                IsActive = resultService.IsActive,
                UpdatedDate = resultService.UpdatedDate
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [Route("changestatus")]
        [HttpPut]
        public ActionResult<CategoryViewModel> ChangeStatus(CategoryViewModel category)
        {
            var resultService = _categoryServices.ChangeStatus(new Category()
            {
                Description = category.Description
            });

            return new CategoryViewModel()
            {
                Id = resultService.Id,
                Key = resultService.Key,
                CreatedDate = resultService.CreatedDate,
                Description = resultService.Description,
                IsActive = resultService.IsActive,
                UpdatedDate = resultService.UpdatedDate
            };
        }


    }
}
