using System.Web.Mvc;
using Planets.Common.Service;
using Planets.Data.Model;

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