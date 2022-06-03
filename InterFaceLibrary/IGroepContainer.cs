using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceLibrary
{
    public interface IGroepContainer
    {
        public GroepDTO Create(GroepDTO dto);
        public void Delete(GroepDTO dto);
        public List<GroepDTO> GetAll();
        public void VoegPersoonAanGroep(int groepId, string gebruikersNaam);

        public GroepDTO FindById(int id);
        public List<GroepDTO> FindByPersoon(int persoonId);
        public GroepDTO FindByNaam(string naam);
    }
}
