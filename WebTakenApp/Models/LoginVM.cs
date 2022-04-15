using System.ComponentModel.DataAnnotations;

namespace WebTakenApp.Models
{
    public class LoginVM
    {
        // Properties
        [Required(ErrorMessage = "Gebruikersnaam is verplicht")]
        [Display(Name = "Gebruikersnaam")]
        public string Gebruikersnaam { get; set; }
        
        [Required(ErrorMessage = "Wachtwoord is verplicht")]
        [Display(Name = "Wachtwoord")]
        [DataType(DataType.Password)]
        public string Wachtwoord { get; set; }
    }
}
