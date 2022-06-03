using BusnLogicTakenApp;

namespace WebTakenApp.Models
{
    public class ProjectVM
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public int GroepId { get; set; }

        public ProjectVM(int id, string naam, string beschrijving, int groepId)
        {
            Id = id;
            Naam = naam;
            Beschrijving = beschrijving;
            GroepId = groepId;
        }

        public ProjectVM(string naam, string beschrijving, int groepId)
        {
            Naam = naam;
            Beschrijving = beschrijving;
            GroepId = groepId;
        }
        public ProjectVM()
        {

        }
        public Project GetProject()
        {
            return new Project(Id, Naam, Beschrijving, GroepId);
        }
    }
}
