using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceLibrary
{
    public class PersoonDTO
    {
        //Fields
        public string Naam { get; set; }
        public int Id { get; set; }
        public string Gebruikersnaam { get; set; }
        public string Email { get; set; }

        public PersoonDTO()
        {
        }

        /// <summary>
        /// Constructor voor PersoonDTO zonder wachtwoordhash
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="id"></param>
        /// <param name="gebruikersnaam"></param>
        /// <param name="email"></param>
        public PersoonDTO(string naam, int id, string gebruikersnaam, string email)
        {
            Naam = naam;
            Id = id;
            Gebruikersnaam = gebruikersnaam;
            Email = email;
        }
    }
}
