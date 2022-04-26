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
        /// <summary>
        /// Constructor voor de PersoonContainer Die een IPersoonContainer implementatie aanroept
        /// </summary>
        /// <param name="container">IPersoonContainer</param>
        public PersoonContainer(IPersoonContainer container)
        {
            this.container = container;
        }
        /// <summary>
        /// Geeft een list van personen die in een bepaalde groep zitten
        /// </summary>
        /// <param name="groepId">Groep Id</param>
        /// <returns></returns>
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
        /// <summary>
        /// Maakt een nieuwe persoon aan
        /// </summary>
        /// <param name="persoon">Persoon</param>
        /// <param name="newWachtwoord">Wachtwoord</param>
        public void Create(Persoon persoon, string newWachtwoord)
        {
            PersoonDTO dto = persoon.GetDTO();
            container.Create(dto, newWachtwoord);
        }
        /// <summary>
        /// Zoekt naar een bepaalde persoon met een bepaalde gebruikernaam en wachtwoord
        /// </summary>
        /// <param name="gebruikersnaam"></param>
        /// <param name="wachtwoord"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Zoekt naar een bepaalde persoon met een bepaalde Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Persoon FindById(int id)
        {
            PersoonDTO dto = container.FindByID(id);
            return new Persoon(dto);
        }
        public Persoon FindByGebruikersnaam(string gebruikersnaam)
        {
            PersoonDTO dto = container.FindByGebruikersnaam(gebruikersnaam);
            return new Persoon(dto);
        }
    }
}
