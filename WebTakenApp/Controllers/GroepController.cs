using BusnLogicTakenApp;
using DALMemoryStore;
using DALMemoryStore.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using WebTakenApp.Models;

namespace WebTakenApp.Controllers
{
    public class GroepController : Controller
    {
        GroepContainer groepContainer = new GroepContainer(new GroepDAL());
        TaakContainer taakContainer = new TaakContainer(new TaakDAL());
        PersoonContainer persoonContainer = new PersoonContainer(new PersoonDAL());
        public IActionResult Index()
        {
            try
            {
                int id = Convert.ToInt32(HttpContext.Session.GetString("PersoonId"));
                if (id != 0)
                {
                    dynamic mymodel = new ExpandoObject();
                    mymodel.GroepVM = GetGroepVMs(id);
                    mymodel.TaakVM = GetTaakVMs(id);
                    return View(mymodel);
                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }
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
        [HttpGet]
        public IActionResult Create()
        {
            try
            {
                GroepVM groepVM = new GroepVM();
                return PartialView("_GroepModelPartial", groepVM);
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

        [HttpPost]
        public IActionResult Create(GroepVM groepVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int id = Convert.ToInt32(HttpContext.Session.GetString("PersoonId"));
                    Persoon persoon = persoonContainer.FindById(id);
                    Groep groep = groepContainer.Create(groepVM.GetGroep());
                    groepContainer.VoegPersoonAanGroep(groep.Id, persoon.Gebruikersnaam);
                    ViewBag.Message = "Groep is gemaakt";
                    return PartialView("_GroepModelPartial", groepVM);
                }
                return View(groepVM);
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
        [HttpPost]
        public IActionResult VoegGroepslidToe(int groepId, string gebruikersnaam)
        {
            try
            {
                if (groepId != null && gebruikersnaam != null)
                {
                    groepContainer.VoegPersoonAanGroep(groepId, gebruikersnaam);
                }
                return RedirectToAction("Index");
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
        private List<GroepVM> GetGroepVMs(int persoonId)
        {
            try
            {
                List<Groep> groepen = groepContainer.FindByPersoon(persoonId);
                List<GroepVM> groepViewModels = groepen.ConvertAll(x => new GroepVM(x));
                return groepViewModels;
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
        private List<TaakVM> GetTaakVMs(int persoonId)
        {
            try
            {
                List<Taak> taken = taakContainer.FindByPersoon(persoonId);
                List<TaakVM> taakViewModels = taken.ConvertAll(x => new TaakVM(x));
                return taakViewModels;
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

