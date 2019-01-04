using Planets.Data.Model;
using Planets.Data.Repositories;
using System.Collections.Generic;

namespace Planets.Common.Service
{
    public interface IImageService
    {
        IEnumerable<Image> GetAllImages();
        Image GetImageById(int id);
        int AddImage(Image image);
        int DeleteImage(Image image);
        int UpdateImage(Image image);
    }

    public class ImageService : IImageService
    {
        private readonly IImagesRepository _imagesRepository;

        public ImageService(IImagesRepository imagesRepository)
        {
            _imagesRepository = imagesRepository;
        }

        public IEnumerable<Image> GetAllImages()
        {
            return _imagesRepository.GetAllImages();
        }

        public Image GetImageById(int id)
        {
            return _imagesRepository.GetImageById(id);
        }

        public int AddImage(Image image)
        {
            return _imagesRepository.AddImage(image);
        }

        public int DeleteImage(Image image)
        {
            return _imagesRepository.DeleteImage(image);
        }

        public int UpdateImage(Image image)
        {
            return _imagesRepository.UpdateImage(image);
        }
    }
}
