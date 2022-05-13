using BusnLogicTakenApp;
using System.ComponentModel.DataAnnotations;

namespace WebTakenApp.Models
{
    public class TaakVM
    {
        //Fields
        public int Id { get;  set; }
        [Required(ErrorMessage = "Vul een naam in")]
        [Display(Name = "Naam")]
        public string Naam { get;  set; }
        [Required(ErrorMessage = "Vul een omschrijving in")]
        [Display(Name = "Omschrijving")]
        public string Beschrijving { get;  set; }
        [Required(ErrorMessage = "Vul een datum in")]
        [Display(Name = "Datum")]
        public DateTime Deadline { get;  set; }
        public int PersoonId { get; set; }
        public int GroepId { get; set; }
        /// <summary>
        /// Constructor voor Taak
        /// </summary>
        /// <param name="id">Taak Id</param>
        /// <param name="Naam">Taaknaam</param>
        /// <param name="Beschrijving">Taakbeschrijving</param>
        /// <param name="deadline">Taakdeadline</param>
        public TaakVM(int id, string Naam, string Beschrijving, DateTime deadline, int persoonId, int groepId)
        {
            this.Id = id;
            this.Naam = Naam;
            this.Beschrijving = Beschrijving;
            this.Deadline = deadline;
            this.PersoonId = persoonId;
            this.GroepId = groepId;
        }
   
        /// <summary>
        /// Constructor voor Taak die een TaakDTO meekrijgt
        /// </summary>
        /// <param name="dto">TaakDTO</param>
        public TaakVM(Taak taak)
        {
            Id = taak.Id;
            Naam = taak.Naam;
            Beschrijving = taak.Beschrijving;
            Deadline = taak.Deadline;
            PersoonId = taak.PersoonId;
            GroepId = taak.GroepId;
        }
        /// <summary>
        /// Constructor voor Taak zonder ID
        /// </summary>
        /// <param name="naam">Taaknaam</param>
        /// <param name="beschrijving">Taakbeschrijving</param>
        /// <param name="deadline">Taakdeadline</param>
        public TaakVM(string naam, string beschrijving, DateTime deadline, int persoonId, int groepId)
        {
            this.Naam = naam;
            this.Beschrijving = beschrijving;
            this.Deadline = deadline;
            this.PersoonId = persoonId;
            this.GroepId = groepId;
        }

        public TaakVM()
        {

        }
        /// <summary>
        /// Geeft een TaakDTO terug van een Taak
        /// </summary>
        /// <returns>TaakDTO</returns>
        public Taak GetTaak()
        {
            return new Taak(Id, Naam, Beschrijving, Deadline, PersoonId, GroepId);
        }
    }
}
