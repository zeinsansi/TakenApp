using BusnLogicTakenApp;
using DALMemoryStore;
using Microsoft.AspNetCore.Mvc;
using WebTakenApp.Models;
using System.Data;
using DALMemoryStore.Exceptions;

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
            try
            {
                if (ModelState.IsValid)
                {
                    Persoon user = persoon.GetPersoon();
                    persoonContainer.Create(user, persoon.Wachtwoord);
                    ViewBag.Message = "Gebruiker is aangemaakt";
                    return RedirectToAction("Index", "Login");
                }
                return View(persoon);
            }
            catch (TemporaryDalException)
            {
                throw new TemporaryDalException($"Check uw verbinding");
            }
            catch (PermanentDalException)
            {
                throw new TemporaryDalException($"Er is iets fout gegaan");
            }
        }
    }
}

