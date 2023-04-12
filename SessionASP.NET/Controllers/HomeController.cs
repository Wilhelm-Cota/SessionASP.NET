using Microsoft.AspNetCore.Mvc;
using SessionASP.NET.Models;
using System.Diagnostics;

namespace SessionASP.NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor contextAccessor;

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor accessor)
        {
            _logger = logger;
            contextAccessor = accessor;
        }

        public IActionResult Index()
        {
            contextAccessor.HttpContext.Session.SetString("StudentName", "Paulus");
            contextAccessor.HttpContext.Session.SetString("StudentNumber", "220085129");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}