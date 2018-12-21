using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Planets.Common.Service;

namespace Planets.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPlanetService _planetService;

        public HomeController(IPlanetService planetService)
        {
            _planetService = planetService;
        }

        public ActionResult Index()
        {
            var response = _planetService.GetPlanetById(2);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}