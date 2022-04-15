using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceLibrary
{
    public class GroepDTO
    {
        public string Naam;
        public int Id;
        public string ProjectNaam;
        public string ProjectBeschrijving;
        public List<PersoonDTO> GroepLeden = new List<PersoonDTO>();
        public GroepDTO(string name, int id, string projectNaam, string projectBeschrijving)
        {
            Naam = name;
            Id = id;
            ProjectNaam = projectNaam;
            ProjectBeschrijving = projectBeschrijving;
        }

        public override bool Equals(object? obj)
        {
            if (obj != null)
            {
                GroepDTO dto = (GroepDTO)obj;
                if (dto.Id == this.Id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
