using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Planets.Common.Service;
using Planets.Data.Model;

namespace Planets.API
{
    [RoutePrefix("api")]
    public class PlanetsController : ApiController
    {
        private readonly IPlanetService _planetService;

        public PlanetsController(IPlanetService planetService)
        {
            _planetService = planetService;
        }

        [HttpGet, Route("planets")]
        public HttpResponseMessage GetPlanets()
        {
            try
            {
                var response = _planetService.GetAllPlanets();
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet, Route("planet")]
        public HttpResponseMessage GetPlanet(long id)
        {
            try
            {
                var response = _planetService.GetPlanetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost, Route("planet/post")]
        public HttpResponseMessage AddNewPlanet(Planet planet)
        {
            try
            {
                var response = _planetService.AddNewPlanet(planet);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut, Route("planet/put")]
        public HttpResponseMessage UpdatePlanet(Planet planet)
        {
            try
            {
                var response = _planetService.UpdatePlanet(planet);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete, Route("planet/delete")]
        public HttpResponseMessage DeletePlanet(Planet planet)
        {
            try
            {
                var response = _planetService.DeleteNewPlanet(planet);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
