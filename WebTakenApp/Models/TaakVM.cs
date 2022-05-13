using BusnLogicTakenApp;

namespace WebTakenApp.Models
{
    public class TaakVM
    {
        //Fields
        public int Id { get;  set; }
        public string Naam { get;  set; }
        public string Beschrijving { get;  set; }
        public DateTime Deadline { get;  set; }
        /// <summary>
        /// Constructor voor Taak
        /// </summary>
        /// <param name="id">Taak Id</param>
        /// <param name="Naam">Taaknaam</param>
        /// <param name="Beschrijving">Taakbeschrijving</param>
        /// <param name="deadline">Taakdeadline</param>
        public TaakVM(int id, string Naam, string Beschrijving, DateTime deadline)
        {
            this.Id = id;
            this.Naam = Naam;
            this.Beschrijving = Beschrijving;
            this.Deadline = deadline;
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
        }
        /// <summary>
        /// Constructor voor Taak zonder ID
        /// </summary>
        /// <param name="naam">Taaknaam</param>
        /// <param name="beschrijving">Taakbeschrijving</param>
        /// <param name="deadline">Taakdeadline</param>
        public TaakVM(string naam, string beschrijving, DateTime deadline)
        {
            Naam = naam;
            Beschrijving = beschrijving;
            Deadline = deadline;
        }
        /// <summary>
        /// Geeft een TaakDTO terug van een Taak
        /// </summary>
        /// <returns>TaakDTO</returns>
        public Taak GetTaak()
        {
            return new Taak(Id, Naam, Beschrijving, Deadline);
        }
    }
}
