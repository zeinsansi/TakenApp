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
                TempData["groepId"] = groepId;
                TempData["persoonId"] = persoonId;
                TempData.Keep();
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
        [HttpGet]
        public IActionResult Create()
        {
            TaakVM taakVM = new TaakVM();
            return PartialView("_TaakModelPartial", taakVM);
        }

        [HttpPost]
        public IActionResult Create(TaakVM taakVM)
        {
            if (ModelState.IsValid)
            {
                
                int groepId = Convert.ToInt32(TempData["groepId"]);
                int persoonId = Convert.ToInt32(TempData["persoonId"]);
                taakVM.GroepId = groepId;
                taakVM.PersoonId = persoonId;
                Taak taak = taakVM.GetTaak();
                taakContainer.Create(taak);
                ViewBag.Message = "Taak is toegevoegd";
                return PartialView("_TaakModelPartial", taakVM);
            }
            return View(taakVM);
            
        }
        
        [HttpGet]
        public IActionResult Update(int taakId)
        {
            Taak taak = taakContainer.FindById(taakId);
            TaakVM taakVM = new TaakVM(taak);
            return PartialView("_EditTaakModelPartial", taakVM);
        }

        [HttpPost]
        public IActionResult Update(TaakVM taakVM)
        {
            if (ModelState.IsValid)
            {
                Taak taak = taakVM.GetTaak();
                taakContainer.Update(taak);
                ViewBag.Message = "Taak is Updated";
                return PartialView("_EditTaakModelPartial", taakVM);
            }
            return View(taakVM);

        }
        [HttpGet]
        public IActionResult Delete(int taakId)
        {
            Taak taak = taakContainer.FindById(taakId);
            TaakVM taakVM = new TaakVM(taak);
            return PartialView("_DeleteTaakModelPartial", taakVM);
        }

        [HttpPost]
        public IActionResult Delete(TaakVM taakVM)
        {
                Taak taak = taakVM.GetTaak();
                taakContainer.Delete(taak.Id);
                ViewBag.Message = "Taak is verwijderd";
                return PartialView("_DeleteTaakModelPartial", taakVM);

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
