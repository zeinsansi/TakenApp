using BusnLogicTakenApp;
using DALMemoryStore;
using Microsoft.AspNetCore.Mvc;
using WebTakenApp.Models;
using System.Data;

namespace WebTakenApp.Controllers
{
    public class RegisterController : Controller
    {
        PersoonContainer persoonContainer = new PersoonContainer(new PersoonDAL());
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PersoonVM persoon)
        {
            if (ModelState.IsValid)
            {
                Persoon user = persoon.GetPersoon();
                persoonContainer.Create(user, persoon.Wachtwoord);
                ViewBag.Message = "Gebruiker is aangemaakt";
                return RedirectToAction("Index","Login");
            }
            return View(persoon);
        }
    }
}

