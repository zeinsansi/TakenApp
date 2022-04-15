using BusnLogicTakenApp;
using System.ComponentModel.DataAnnotations;

namespace WebTakenApp.Models
{
    public class PersoonVM
    {
        public int Id;
        [Required(ErrorMessage = "Naam is verplicht")]
        [Display(Name = "Naam")]
        public string Naam { get; set; }
        [Required(ErrorMessage = "Gebruikersnaam is verplicht")]
        [Display(Name = "Gebruikersnaam")]
        public string Gebruikersnaam { get;  set; }
        [Required(ErrorMessage = "Email is verplicht")]
        [Display(Name = "Email")]
        public string Email { get;  set; }
        [Required(ErrorMessage = "Wachtwoord is verplicht")]
        [Display(Name = "Wachtwoord")]
        [DataType(DataType.Password)]
        public string Wachtwoord { get;  set; }


        public PersoonVM(int id, string name, string gebruikersnaam, string email, string wachtwoord)
        {
            Id = id;
            Naam = name;
            Gebruikersnaam = gebruikersnaam;
            Email = email;
            Wachtwoord = wachtwoord;
        }
        public PersoonVM(Persoon persoon)
        {
            this.Id = persoon.Id;
            this.Naam = persoon.Naam;
            this.Gebruikersnaam = persoon.Gebruikersnaam;
            this.Email = persoon.Email;
        }
        public PersoonVM()
        {

        }
        public Persoon GetPersoon()
        {
            return new Persoon( this.Naam, this.Gebruikersnaam, this.Email);
        }
    }
}
