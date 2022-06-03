using InterFaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusnLogicTakenApp
{
    /// <summary>
    /// Deze Class is voor groep waarin list van groepsleden zitten
    /// </summary>
    public class Groep
    {
        //Fields
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public List<Persoon> GroepLeden { get; set; } = new List<Persoon>();
        public Project Project { get; set; } = new();
        /// <summary>
        /// Constructor voor groep
        /// </summary>
        /// <param name="Id">Groep Id</param>
        /// <param name="Naam">Groep Naam</param>
        public Groep(int Id, string Naam)
        {
            this.Id = Id;
            this.Naam = Naam;

        }
        public Groep(Groep groep)
        {
            this.Id = groep.Id;
            this.Naam = groep.Naam;
            this.GroepLeden = groep.GroepLeden;
            this.Project = groep.Project;
        }

        /// <summary>
        /// Controctor voor groep zonder Id
        /// </summary>
        /// <param name="Naam">Groep Naam</param>
        public Groep( string Naam)
        {
            this.Naam = Naam;

        }
        /// <summary>
        /// Constroctor voor groep die GroepDTO krijgt
        /// </summary>
        /// <param name="dto">GroepDTO</param>
        public Groep(GroepDTO dto)
        {
            Id = dto.Id;
            Naam = dto.Naam;
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
            GroepDTO dto = new GroepDTO(Naam, Id);
            return dto;
        }

        public override string ToString()
        {
                return $"Naam: {this.Naam}\n Project: {this.Project.Naam}\n Beschrijving: {this.Project.Beschrijving}";
        }
    }
}
