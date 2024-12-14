using Microsoft.AspNetCore.Mvc;

namespace WeatherApp.API.Controllers
{
    public class RecommendationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
