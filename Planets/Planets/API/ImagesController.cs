using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Planets.Common.Service;

namespace Planets.API
{
    [RoutePrefix("api")]
    public class ImagesController : ApiController
    {
        private readonly IImageService _imageService;

        public ImagesController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpGet, Route("images")]
        public HttpResponseMessage GetAllImages()
        {
            try
            {
                var response = _imageService.GetAllImages();
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
