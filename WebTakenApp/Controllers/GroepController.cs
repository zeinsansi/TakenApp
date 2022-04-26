using BusnLogicTakenApp;
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
            if (HttpContext.Session.GetString("PersoonId") != null)
            {
                int persoonId = Convert.ToInt32(HttpContext.Session.GetString("PersoonId"));
                List<Groep> groepen = groepContainer.GetAll();
                List<GroepVM> groepViewModels = new List<GroepVM>();
                foreach (Groep groep in groepen)
                {
                    groepViewModels.Add(new GroepVM(groep.Id, groep.Naam, groep.ProjectNaam, groep.ProjectBeschrijving));
                }
                return View(groepViewModels);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}
