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
        //Fields
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public string Gebruikersnaam { get; private set; }
        public string Email { get; private set; }
        
        /// <summary>
        /// Constuctor voor de Persoon class zonder Id
        /// </summary>
        /// <param name="Naam">Persoon naam</param>
        /// <param name="GebruikerNaam">Gebruikernaam</param>
        public Persoon(string Naam, string GebruikerNaam, string Email)
        {
            this.Naam = Naam;
            this.Gebruikersnaam = GebruikerNaam;
            this.Email = Email;
        }
        /// <summary>
        /// Constuctor voor de Persoon class die een PersoonDTO meekrijgt
        /// </summary>
        /// <param name="dto"></param>
        public Persoon(PersoonDTO dto)
        {

            Id = dto.Id;
            Naam = dto.Naam;
            Gebruikersnaam = dto.Gebruikersnaam;
            Email = dto.Email;

        }
        /// <summary>
        /// Methode om van een Persoon een PersoonDTO te maken
        /// </summary>
        /// <returns>PersoonDTO</returns>
        internal PersoonDTO GetDTO()
        {
            PersoonDTO dto = new PersoonDTO(Naam, Id, Gebruikersnaam, Email);
            return dto;
        }

        public override string ToString()
        {
            return $"{this.Naam}";
        }
    }
}
