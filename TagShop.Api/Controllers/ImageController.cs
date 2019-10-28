using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TagShop.Api.ViewModels.Images;
using TagShop.Domain.Models;
using TagShop.Services.Interfaces;

namespace TagShop.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : BaseController
    {
        private readonly IImageServices _imageServices;
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="saleitemServices"></param>
        /// <param name="mapper"></param>
        public ImageController(IImageServices imageServices, IMapper mapper)
        {
            _imageServices = imageServices;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<ImageViewModel>> GetAll()
        {
            var resultService = _imageServices.GetAll();


            return _mapper.Map<List<ImageViewModel>>(resultService);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<ImageViewModel> Post(CreateImageViewModel image)
        {
            var resultService = _imageServices.Insert(_mapper.Map<Image>(image));

            return _mapper.Map<ImageViewModel>(resultService);

        }
    }
}
