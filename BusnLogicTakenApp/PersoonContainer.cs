using InterFaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusnLogicTakenApp
{
    public class PersoonContainer
    {
        private readonly IPersoonContainer container;

        public PersoonContainer(IPersoonContainer container)
        {
            this.container = container;
        }
        public List<Persoon>  FindByGroepId(int groepId)
        {
            List<PersoonDTO> dtos = container.FindByGroepId(groepId);
            List<Persoon> groepLeden = new List<Persoon>();
            foreach (PersoonDTO dto in dtos)
            {
                groepLeden.Add(new Persoon(dto));
            }
            return groepLeden;
        }
        public void Create(Persoon persoon, string newWachtwoord)
        {
            PersoonDTO dto = persoon.GetDTO();
            container.Create(dto, newWachtwoord);
        }
        public Persoon LogIn(string gebruikersnaam, string wachtwoord)
        {
            PersoonDTO dto = container.LogIn(gebruikersnaam, wachtwoord);
            if (dto == null)
            {
                return null;
            }
            else
            {
                return new Persoon(dto);
            }
        }
        
        public Persoon FindById(int id)
        {
            PersoonDTO dto = container.FindByID(id);
            return new Persoon(dto);
        }
    }
}
