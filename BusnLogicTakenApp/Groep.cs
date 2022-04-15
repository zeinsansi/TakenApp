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
        //Fields
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public string ProjectNaam { get; private set; }
        public string ProjectBeschrijving { get; private set; }
        public List<Persoon> GroepLeden { get; set; } = new List<Persoon>();
        /// <summary>
        /// Constructor voor groep
        /// </summary>
        /// <param name="Id">Groep Id</param>
        /// <param name="Naam">Groep Naam</param>
        /// <param name="ProjectNaam">Project Naam</param>
        /// <param name="ProjectBeschrijving">Project Beschrijving</param>
        public Groep(int Id, string Naam, string ProjectNaam, string ProjectBeschrijving)
        {
            this.Id = Id;
            this.Naam = Naam;
            this.ProjectNaam = ProjectNaam;
            this.ProjectBeschrijving = ProjectBeschrijving;

        }
        /// <summary>
        /// Controctor voor groep zonder Id
        /// </summary>
        /// <param name="Naam">Groep Naam</param>
        /// <param name="ProjectNaam">Project Naam</param>
        /// <param name="ProjectBeschrijving">Project Beschrijving</param>
        public Groep( string Naam, string ProjectNaam, string ProjectBeschrijving)
        {
            this.Naam = Naam;
            this.ProjectNaam = ProjectNaam;
            this.ProjectBeschrijving = ProjectBeschrijving;

        }
        /// <summary>
        /// Constroctor voor groep die GroepDTO krijgt
        /// </summary>
        /// <param name="dto">GroepDTO</param>
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
        /// <summary>
        /// Methode die geeft GroepDTO terug
        /// </summary>
        /// <returns>Geeft een GroepDTO terug</returns>
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
