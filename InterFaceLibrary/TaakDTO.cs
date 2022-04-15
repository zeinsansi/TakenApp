using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceLibrary
{
    public class TaakDTO
    {
        /// <summary>  De unieke id van de Taak </summary>
        public int Id;
        /// <summary>  De naam van de Taak </summary>
        public string Naam;
        /// <summary>  De beschrijving van de taak  </summary>
        public string Beschrijving;
        /// <summary>  Het deadline van de taak  </summary>
        public DateTime Deadline;

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
