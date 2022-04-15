using BusnLogicTakenApp;
using DALMemoryStore;
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
            Groep groep = groepContainer.FindById(groepId);
            groep.GroepLeden = persoonContainer.FindByGroepId(groepId);
            GroepVM vm = new GroepVM(groep);
            return View(vm);

        }
    }
}
