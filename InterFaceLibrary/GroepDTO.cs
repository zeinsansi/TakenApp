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
        public List<PersoonDTO> GroepLeden = new List<PersoonDTO>();
        public ProjectDTO project { get; set; } = new();
        /// <summary>
        /// Constructor voor groep
        /// </summary>
        /// <param name="name">Groep Naam</param> 
        /// <param name="id">Groep Id</param>
        public GroepDTO(string name, int id)
        {
            Naam = name;
            Id = id;
        }
        public GroepDTO(string name, int id,  List<PersoonDTO> groepLeden)
        {
            Naam = name;
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
