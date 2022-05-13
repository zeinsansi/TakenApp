using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceLibrary
{
    public class GroepDTO
    {
        //Fields
        public string Naam { get; set; }
        public int Id { get; set; }
        public string ProjectNaam { get; set; }
        public string ProjectBeschrijving { get; set; }
        public List<PersoonDTO> GroepLeden = new List<PersoonDTO>();
        /// <summary>
        /// Constructor voor groep
        /// </summary>
        /// <param name="name">Groep Naam</param> 
        /// <param name="id">Groep Id</param>
        /// <param name="projectNaam">Project Naam</param>
        /// <param name="projectBeschrijving">Project Beschrijving</param>
        public GroepDTO(string name, int id, string projectNaam, string projectBeschrijving)
        {
            Naam = name;
            Id = id;
            ProjectNaam = projectNaam;
            ProjectBeschrijving = projectBeschrijving;
        }
        public GroepDTO(string name, int id, string projectNaam, string projectBeschrijving, List<PersoonDTO> groepLeden)
        {
            Naam = name;
            Id = id;
            ProjectNaam = projectNaam;
            ProjectBeschrijving = projectBeschrijving;
            GroepLeden = groepLeden;
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
