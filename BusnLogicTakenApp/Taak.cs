using InterFaceLibrary;

namespace BusnLogicTakenApp
{
    public class Taak
    {
        /// <summary>  De unieke id van de Taak </summary>
        public int Id { get; private set; }
        /// <summary>  De naam van de Taak </summary>
        public string Naam { get; private set; }
        /// <summary>  De beschrijving van de taak  </summary>
        public string Beschrijving { get; private set; }
        /// <summary>  Het deadline van de taak  </summary>
        public DateTime Deadline { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Naam"></param>
        /// <param name="Beschrijving"></param>
        /// <param name="deadline"></param>
        public Taak(int id, string Naam, string Beschrijving, DateTime deadline)
        {
            this.Id = id;
            this.Naam = Naam;
            this.Beschrijving = Beschrijving;
            this.Deadline = deadline;
        }

        public Taak(TaakDTO dto)
        {           
            Id = dto.Id;
            Naam = dto.Naam;
            Beschrijving = dto.Beschrijving;
            Deadline = dto.Deadline;
        }

        public Taak(string naam, string beschrijving, DateTime deadline)
        {
            Naam = naam;
            Beschrijving = beschrijving;
            Deadline = deadline;
        }

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