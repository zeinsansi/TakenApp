using Microsoft.AspNetCore.Mvc;

namespace WebTakenApp.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult TemporaryDalException(string message)
        {
            ViewBag.Message = message;
            return View();
        }

        public IActionResult PermanentDalException()
        {
            return View();
        }
    }
}
