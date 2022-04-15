using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceLibrary
{
    public class PersoonDTO
    {
        public string Naam;
        public int Id;
        public string Gebruikersnaam;
        public string Email;
        public string Wachtwoord;

        public PersoonDTO()
        {
        }

        public PersoonDTO(string name, int id, string gebruikersnaam, string email, string wachtwoord)
        {
            Naam = name;
            Id = id;
            Gebruikersnaam = gebruikersnaam;
            Email = email;
            Wachtwoord = wachtwoord;
        }
        
    }
}
