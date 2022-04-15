using BusnLogicTakenApp;
using DALMemoryStore;
using Microsoft.AspNetCore.Mvc;
using WebTakenApp.Models;

namespace WebTakenApp.Controllers
{
    public class GroepController : Controller
    {
        GroepContainer groepContainer = new GroepContainer(new GroepDAL());
/*        PersoonContainer persoonContainer = new PersoonContainer(new PersoonDAL());
        public IActionResult Henk()
        {
            int groepId = 1;
            Groep groep = groepContainer.FindById(groepId);
            groep.GroepLeden = persoonContainer.FindByGroepId(groepId);
            GroepVM vm = new GroepVM(groep);
            //List<Persoon> groepLeden = persoonContainer.FindByGroepId(groepId);
            //List<PersoonVM> VM = new List<PersoonVM>();
            //foreach (Persoon persoon in groepLeden)
            //{
            //    VM.Add(new PersoonVM(persoon));
            //}
            return View(vm);
        }*/
        public IActionResult Index()
        {
            List<Groep> groepen = groepContainer.GetAll();
            List<GroepVM> groepViewModels = new List<GroepVM>();
            foreach (Groep groep in groepen)
            {
                groepViewModels.Add(new GroepVM(groep.Id, groep.Naam, groep.ProjectNaam, groep.ProjectBeschrijving));
            }
            return View(groepViewModels);
        }
    }
}
