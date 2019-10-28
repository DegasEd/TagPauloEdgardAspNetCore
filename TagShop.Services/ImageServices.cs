using System;
using System.Collections.Generic;
using System.Text;
using TagShop.Domain.Models;
using TagShop.Repository.Interfaces;
using TagShop.Services.Interfaces;

namespace TagShop.Services
{
    class ImageServices : IImageServices
    {
        private readonly IImageRepository _imageRepository;

        public ImageServices(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public List<Image> GetAll()
        {
            return _imageRepository.GetAll();
        }

        public Image Insert(Image obj)
        {
            return _imageRepository.Insert(obj);
        }
    }
}
