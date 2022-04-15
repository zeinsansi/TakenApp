using InterFaceLibrary;

namespace BusnLogicTakenApp
{
    public class Taak
    {
        //Fields
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public string Beschrijving { get; private set; }
        public DateTime Deadline { get; private set; }
        /// <summary>
        /// Constructor voor Taak
        /// </summary>
        /// <param name="id">Taak Id</param>
        /// <param name="Naam">Taaknaam</param>
        /// <param name="Beschrijving">Taakbeschrijving</param>
        /// <param name="deadline">Taakdeadline</param>
        public Taak(int id, string Naam, string Beschrijving, DateTime deadline)
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
        public Taak(TaakDTO dto)
        {           
            Id = dto.Id;
            Naam = dto.Naam;
            Beschrijving = dto.Beschrijving;
            Deadline = dto.Deadline;
        }
        /// <summary>
        /// Constructor voor Taak zonder ID
        /// </summary>
        /// <param name="naam">Taaknaam</param>
        /// <param name="beschrijving">Taakbeschrijving</param>
        /// <param name="deadline">Taakdeadline</param>
        public Taak(string naam, string beschrijving, DateTime deadline)
        {
            Naam = naam;
            Beschrijving = beschrijving;
            Deadline = deadline;
        }
        /// <summary>
        /// Geeft een TaakDTO terug van een Taak
        /// </summary>
        /// <returns>TaakDTO</returns>
        public TaakDTO GetDTO()
        {
            TaakDTO dto = new TaakDTO(Id, Naam, Beschrijving, Deadline);
            return dto;
        }

        public override string ToString()
        {
            return $"{this.Naam}";
        }
    }
}