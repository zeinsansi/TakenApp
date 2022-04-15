using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceLibrary
{
    public class PersoonDTO
    {
        public string Naam { get; set; }
        public int Id { get; set; }
        public string Gebruikersnaam { get; set; }
        public string Email { get; set; }
        public string WachtwoordHash { get; set; }

        public PersoonDTO()
        {
        }

        public PersoonDTO(string name, int id, string gebruikersnaam, string email, string wachtwoordHash)
        {
            Naam = name;
            Id = id;
            Gebruikersnaam = gebruikersnaam;
            Email = email;
            WachtwoordHash = wachtwoordHash;
        }

        public PersoonDTO(string naam, int id, string gebruikersnaam, string email)
        {
            Naam = naam;
            Id = id;
            Gebruikersnaam = gebruikersnaam;
            Email = email;
        }
    }
}
