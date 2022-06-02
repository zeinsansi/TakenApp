using BusnLogicTakenApp;
using DALMemoryStore;
using DALMemoryStore.Exceptions;
using Microsoft.AspNetCore.Mvc;
using WebTakenApp.Models;

namespace WebTakenApp.Controllers
{
    public class LoginController : Controller
    {
        PersoonContainer persoonContainer = new PersoonContainer(new PersoonDAL());
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginVM login)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (persoonContainer.LogIn(login.Gebruikersnaam, login.Wachtwoord) != null)
                    {
                        Persoon persoon = persoonContainer.FindByGebruikersnaam(login.Gebruikersnaam);
                        HttpContext.Session.SetString("PersoonId", persoon.Id.ToString());
                        return RedirectToAction("Index", "Groep");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Gebruikersnaam of wachtwoord is incorrect");
                    }
                }
                return View();
            }
            catch (TemporaryDalException ex)
            {
                ViewBag.Message = ex.Message;
                return Content(ex.Message);
            }
            catch (PermanentDalException ex)
            {
                ViewBag.Message = ex.Message;
                return Content(ex.Message);
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}
