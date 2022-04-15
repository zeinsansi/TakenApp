using BusnLogicTakenApp;

namespace WebTakenApp.Models
{
    public class GroepVM
    {
        public int Id;
        public string Naam;
        public string ProjectNaam;
        public string ProjectBeschrijving;
        public List<PersoonVM> personen = new List<PersoonVM>();

        public GroepVM(int id, string name, string projectNaam, string projectBeschrijving)
        {
            Naam = name;
            Id = id;
            ProjectNaam = projectNaam;
            ProjectBeschrijving = projectBeschrijving;
        }

        public GroepVM(Groep groep)
        {
            Id = groep.Id;
            Naam = groep.Naam;
            ProjectNaam = groep.ProjectNaam;
            ProjectBeschrijving = groep.ProjectBeschrijving;
            foreach (var d in groep.GroepLeden)
            {
                personen.Add(new PersoonVM(d));
            }
        }
        public Groep GetGroep()
        {
            return new Groep(Id, Naam, ProjectNaam, ProjectBeschrijving);
        }
        
        public GroepVM()
        {

        }
    }
}
