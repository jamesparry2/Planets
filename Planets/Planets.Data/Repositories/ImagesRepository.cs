using Planets.Data.DataContextLayer;
using Planets.Data.Model;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Planets.Data.Repositories
{
    public interface IImagesRepository
    {
        IEnumerable<Image> GetAllImages();
        Image GetImageById(int id);
        int AddImage(Image image);
        int DeleteImage(Image image);
        int UpdateImage(Image image);
    }

    public class ImagesRepository : IImagesRepository
    {
        
        public IEnumerable<Image> GetAllImages()
        {
            var response = new List<Image>();
            using(var contex = new PlanetContext())
            {
                response = contex.Images.SqlQuery("SELECT * FROM Images").ToList();
            }
            return response;
        }

        public Image GetImageById(int id)
        {
            var response = new Image();
            using(var context = new PlanetContext())
            {
                response = context.Images.Find(id);
            }
            return response;
        }

        public int AddImage(Image image)
        {
            var rowsAffected = 0;
            using(var context = new PlanetContext())
            {
                context.Images.Add(image);
                rowsAffected = context.SaveChanges();
            }
            return rowsAffected;
        }

        public int DeleteImage(Image image)
        {
            var rowsAffected = 0;
            using(var context = new PlanetContext())
            {
                context.Images.Remove(image);
                rowsAffected = context.SaveChanges();
            }
            return rowsAffected;
        }

        public int UpdateImage(Image image)
        {
            var rowsAffected = 0;
            using(var context = new PlanetContext())
            {
                var sqlParams = new List<SqlParameter>
                {
                    new SqlParameter("@ImageUriPath", image.ImageUriPath)
                };

                var sqlQuery = @"
                    UPDATE Images
                    SET ImageUriPath = @ImageUriPath
                    WHERE ImageId = @ImageId";

                context.Images.SqlQuery(sqlQuery, sqlParams);
                rowsAffected = context.SaveChanges();
            }
            return rowsAffected;
        }
    }
}
