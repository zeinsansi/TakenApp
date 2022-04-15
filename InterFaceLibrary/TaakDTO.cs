using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceLibrary
{
    public class TaakDTO
    {
        //Fields
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public DateTime Deadline { get; set; }
        /// <summary>
        /// Constructor voor TaakDTO
        /// </summary>
        /// <param name="id">Taak Id</param>
        /// <param name="name">Taaknaam</param>
        /// <param name="beschrijving">Taakbeschrijving</param>
        /// <param name="deadline">Taakdeadline</param>
        public TaakDTO(int id, string name, string beschrijving, DateTime deadline)
        {
            Id = id;
            Naam = name;
            Beschrijving = beschrijving;
            Deadline = deadline;
        }

        public override bool Equals(object? obj)
        {
            if(obj != null)
            {
                TaakDTO dto = (TaakDTO)obj;
                if(dto.Id == this.Id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
