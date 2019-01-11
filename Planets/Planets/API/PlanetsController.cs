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
    public class PlanetsController : ApiController
    {
        private readonly IPlanetService _planetService;

        public PlanetsController(IPlanetService planetService)
        {
            _planetService = planetService;
        }

        [Route("planets")]
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
    }
}
