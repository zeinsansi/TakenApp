using InterFaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusnLogicTakenApp
{
    public class Persoon
    {
        public int Id { get; private set; }
        /// <summary>  De naam van de persoon  </summary>
        public string Naam { get; private set; }
        /// <summary> /// De unieke gebruikersnaan van de persoon /// </summary>
        public string Gebruikersnaam { get; private set; }
        public string Email { get; private set; }
        public string Wachtwoord { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Naam"></param>
        /// <param name="GebruikerNaam"></param>
        public Persoon(string Naam, string GebruikerNaam, string Email, string Wachtwoord)
        {
            this.Naam = Naam;
            this.Gebruikersnaam = GebruikerNaam;
            this.Email = Email;
            this.Wachtwoord = Wachtwoord;
        }

        public Persoon(PersoonDTO dto)
        {

            Id = dto.Id;
            Naam = dto.Naam;
            Gebruikersnaam = dto.Gebruikersnaam;
            Email = dto.Email;
            Wachtwoord = dto.Wachtwoord;

        }

        internal PersoonDTO GetDTO()
        {
            PersoonDTO dto = new PersoonDTO(Naam, Id, Gebruikersnaam, Email, Wachtwoord);
            return dto;
        }

        public override string ToString()
        {
            return $"{this.Naam}";
        }
    }
}
