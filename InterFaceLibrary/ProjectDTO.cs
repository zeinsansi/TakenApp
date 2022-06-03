using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceLibrary
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public int GroepId { get; set; }

        public ProjectDTO(int id, string naam, string beschrijving, int groepId)
        {
            Id = id;
            Naam = naam;
            Beschrijving = beschrijving;
            GroepId = groepId;
        }

        public ProjectDTO(string naam, string beschrijving, int groepId)
        {
            Naam = naam;
            Beschrijving = beschrijving;
            GroepId = groepId;
        }
        public ProjectDTO()
        {
            
        }
    }
}
