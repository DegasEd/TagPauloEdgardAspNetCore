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

        public CategoryController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        /// <summary>
        /// GetAll
        /// </summary>
        /// <returns>List of CategoryViewModel</returns>
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
                    CategoryId = c.CategoryId,
                    CreatedDate = c.CreatedDate,
                    Description = c.Description,
                    IsActive = c.IsActive,
                    Key = c.Key,
                    UpdatedDate = c.UpdatedDate
                });
            });
            return result;
        }

        /// <summary>
        /// GetById
        /// </summary>
        /// <param name="id">Id of Category</param>
        /// <returns>CategoryViewModel by id</returns>
        [HttpGet("{id}")]
        public ActionResult<CategoryViewModel> Get(int id)
        {
            var resultService = _categoryServices.GetById(id);

            return new CategoryViewModel()
            {
                Id = resultService.Id,
                CategoryId = resultService.CategoryId,
                CreatedDate = resultService.CreatedDate,
                Description = resultService.Description,
                IsActive = resultService.IsActive,
                Key = resultService.Key,
                UpdatedDate = resultService.UpdatedDate
            };
        }

       /// <summary>
       /// Post CategoryViewModel
       /// </summary>
       /// <param name="category">Json CategoryViewModel</param>
       /// <returns>Inserted CategoryViewModel</returns>
        [HttpPost]
        public ActionResult<CategoryViewModel> Post(CategoryViewModel category)
        {
            var resultService = _categoryServices.Insert(new Category()
            {
                CategoryId = category.CategoryId,
                Description = category.Description,
            });

            return new CategoryViewModel() 
            {
                Id = resultService.Id,
                CategoryId = resultService.CategoryId,
                CreatedDate = resultService.CreatedDate,
                Description = resultService.Description,
                IsActive = resultService.IsActive,
                Key = resultService.Key,
                UpdatedDate = resultService.UpdatedDate
            };

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>        
        [HttpPut]
        public ActionResult<CategoryViewModel> Put(CategoryViewModel category)
        {
            var resultService = _categoryServices.Update(new Category()
            {
                CategoryId = category.CategoryId,
                Description = category.Description,
            });

            return new CategoryViewModel()
            {
                Id = resultService.Id,
                CategoryId = resultService.CategoryId,
                CreatedDate = resultService.CreatedDate,
                Description = resultService.Description,
                IsActive = resultService.IsActive,
                Key = resultService.Key,
                UpdatedDate = resultService.UpdatedDate
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<CategoryViewModel> ChangeStatus(CategoryViewModel category)
        {
            var resultService = _categoryServices.ChangeStatus(new Category()
            {
                CategoryId = category.CategoryId,
                Description = category.Description,
            });

            return new CategoryViewModel()
            {
                Id = resultService.Id,
                CategoryId = resultService.CategoryId,
                CreatedDate = resultService.CreatedDate,
                Description = resultService.Description,
                IsActive = resultService.IsActive,
                Key = resultService.Key,
                UpdatedDate = resultService.UpdatedDate
            };
        }
    }
}
