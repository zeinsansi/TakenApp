using BusnLogicTakenApp;
using DALMemoryStore;
using DALMemoryStore.Exceptions;
using Microsoft.AspNetCore.Mvc;
using WebTakenApp.Models;

namespace WebTakenApp.Controllers
{
    public class PersoonController : Controller
    {
        GroepContainer groepContainer = new GroepContainer(new GroepDAL());
        PersoonContainer persoonContainer = new PersoonContainer(new PersoonDAL());
        public IActionResult Index(int groepId)
        {
            try
            {
                Groep groep = groepContainer.FindById(groepId);
                groep.GroepLeden = persoonContainer.FindByGroepId(groepId);
                GroepVM vm = new GroepVM(groep);
                return View(vm);
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
    }
}
