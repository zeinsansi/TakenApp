﻿using BusnLogicTakenApp;
using DALMemoryStore;
using Microsoft.AspNetCore.Mvc;
using WebTakenApp.Models;

namespace WebTakenApp.Controllers
{
    public class GroepController : Controller
    {
        GroepContainer groepContainer = new GroepContainer(new GroepDAL());
        public IActionResult Index()
        {
            int id = Convert.ToInt32(HttpContext.Session.GetString("PersoonId"));
            if (id != 0)
            {
                List<GroepVM> groepViewModels = GetGroepVMs();
                return View(groepViewModels);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        private List<GroepVM> GetGroepVMs()
        {
            List<Groep> groepen = groepContainer.GetAll();
            List<GroepVM> groepViewModels = groepen.ConvertAll(x => new GroepVM(x));
            return groepViewModels;
        }
    }
}

