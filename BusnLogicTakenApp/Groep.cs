using InterFaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusnLogicTakenApp
{
    public class Groep
    {
        public int Id { get; private set; }
        /// <summary>  De naam van de groep  </summary>
       /* private string Naam;*/
        public string Naam { get; private set; }
        /// <summary>  De naam van de groep project  </summary>
        public string ProjectNaam { get; private set; }
        /// <summary>  De beschrijving van groep project  </summary>
        public string ProjectBeschrijving { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Naam"></param>
        /// <param name="ProjectNaam"></param>
        /// <param name="ProjectBeschrijving"></param>
        /// 
        public List<Persoon> GroepLeden { get; set; } = new List<Persoon>();
        public Groep(int Id, string Naam, string ProjectNaam, string ProjectBeschrijving)
        {
            this.Id = Id;
            this.Naam = Naam;
            this.ProjectNaam = ProjectNaam;
            this.ProjectBeschrijving = ProjectBeschrijving;

        }
        public Groep( string Naam, string ProjectNaam, string ProjectBeschrijving)
        {
            this.Naam = Naam;
            this.ProjectNaam = ProjectNaam;
            this.ProjectBeschrijving = ProjectBeschrijving;

        }

        public Groep(GroepDTO dto)
        {
            Id = dto.Id;
            Naam = dto.Naam;
            ProjectNaam = dto.ProjectNaam;
            ProjectBeschrijving = dto.ProjectBeschrijving;
            foreach(var d in dto.GroepLeden)
            {
                GroepLeden.Add(new Persoon(d));
            }
        }

        public GroepDTO GetDTO()
        {
            GroepDTO dto = new GroepDTO(Naam, Id, ProjectNaam, ProjectBeschrijving);
            return dto;
        }

        public override string ToString()
        {
                return $"Naam: {this.Naam}\n Project: {this.ProjectNaam}\n Beschrijving: {this.ProjectBeschrijving}";
        }
    }
}
