using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFaceLibrary;

namespace BusnLogicTakenApp
{
    public class GroepContainer
    {
        private readonly IGroepContainer container;
        /// <summary>
        /// Constructor voor de groepcontainer die krijgt een IGroepContainer mee
        /// </summary>
        /// <param name="container"></param>
        public GroepContainer(IGroepContainer container)
        {
            this.container = container;
        }
        /// <summary>
        /// Maakt een new groep aan
        /// </summary>
        /// <param name="groep">Groep</param>
        public void Create(Groep groep)
        {
            GroepDTO dto = groep.GetDTO();
            container.Create(dto);
        }
        /// <summary>
        /// Zoekt naar een bepaalde groep met bepaalde Id
        /// </summary>
        /// <param name="id">Groep Id</param>
        /// <returns>Groep</returns>
        public Groep FindById(int id)
        {
            GroepDTO dto = container.FindById(id);
            return new Groep(dto);
        }
        /// <summary>
        /// Geeft alle Groepen Terug
        /// </summary>
        /// <returns>List met alle Groepen</returns>
        public List<Groep> GetAll()
        {
            List<GroepDTO> dtos = container.GetAll();
            List<Groep> groepen = new List<Groep>();
            foreach (GroepDTO dto in dtos)
            {
                groepen.Add(new Groep(dto));
            }
            return groepen;
        }
        /// <summary>
        /// Verwijdert bepaalde Groep
        /// </summary>
        /// <param name="groep">Groep</param>
        public void Delete(Groep groep)
        {
            GroepDTO dto = groep.GetDTO();
            container.Delete(dto);
        }
        /// <summary>
        /// Voegt een bepaalde Persoon aan een bepaalde Groep
        /// </summary>
        /// <param name="groepId">Groep Id</param>
        /// <param name="gebruikersNaam">Gebruikernaam</param>
        public void VoegPersoonAanGroep(int groepId, string gebruikersNaam)
        {
            container.VoegPersoonAanGroep(groepId, gebruikersNaam);
        }
    }
}
