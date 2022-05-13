using BusnLogicTakenApp;
using DALMemoryStore;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using WebTakenApp.Models;

namespace WebTakenApp.Controllers
{
    public class TaakController : Controller
    {
        GroepContainer groepContainer = new GroepContainer(new GroepDAL());
        TaakContainer taakContainer = new TaakContainer(new TaakDAL());
        public IActionResult Index(int groepId, int persoonId)
        {
            int id = Convert.ToInt32(HttpContext.Session.GetString("PersoonId"));
            if (id != 0)
            {
                dynamic mymodel = new ExpandoObject();
                mymodel.GroepVM = GetGroepVMs();
                mymodel.TaakVM = GetTaakVMs(groepId, persoonId);
                return View(mymodel);
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
        private List<TaakVM> GetTaakVMs(int groepId, int persoonId)
        {
            List<Taak> taken = taakContainer.FindByPersoonInGroep(groepId, persoonId);
            List<TaakVM> taakViewModels = taken.ConvertAll(x => new TaakVM(x));
            return taakViewModels;
        }
    }
}
