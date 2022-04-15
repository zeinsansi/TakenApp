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
        public GroepContainer(IGroepContainer container)
        {
            this.container = container;
        }
        public void Create(Groep groep)
        {
            GroepDTO dto = groep.GetDTO();
            container.Create(dto);
        }

        public Groep FindById(int id)
        {
            GroepDTO dto = container.FindById(id);
            return new Groep(dto);
        }
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
        public void Delete(Groep groep)
        {
            GroepDTO dto = groep.GetDTO();
            container.Delete(dto);
        }
        public void VoegPersoonAanGroep(int groepId, string gebruikersNaam)
        {
            container.VoegPersoonAanGroep(groepId, gebruikersNaam);
        }
    }
}
