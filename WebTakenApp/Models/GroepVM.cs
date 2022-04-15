using BusnLogicTakenApp;

namespace WebTakenApp.Models
{
    public class GroepVM
    {
        //Fields
        public int Id { get; set; }
        public string Naam { get; set; }
        public string ProjectNaam { get; set; }
        public string ProjectBeschrijving { get; set; }
        public List<PersoonVM> personen = new List<PersoonVM>();

        /// <summary>
        /// Constructor voor GroepVM
        /// </summary>
        /// <param name="id">Groep Id</param>
        /// <param name="name">Groep naam</param>
        /// <param name="projectNaam">Groep projectNaam</param>
        /// <param name="projectBeschrijving">Groep projectBeschrijving</param>
        public GroepVM(int id, string name, string projectNaam, string projectBeschrijving)
        {
            Naam = name;
            Id = id;
            ProjectNaam = projectNaam;
            ProjectBeschrijving = projectBeschrijving;
        }
        /// <summary>
        /// Constructor voor GroepVM die een groep meekrijgt
        /// </summary>
        /// <param name="groep">Groep</param>
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
        /// <summary>
        /// Geeft een groep terug
        /// </summary>
        /// <returns>Groep</returns>
        public Groep GetGroep()
        {
            return new Groep(Id, Naam, ProjectNaam, ProjectBeschrijving);
        }
        
        public GroepVM()
        {

        }
    }
}
