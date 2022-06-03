using InterFaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusnLogicTakenApp
{
    public class Project
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public int GroepId { get; set; }

        public Project(int id, string naam, string beschrijving, int groepId)
        {
            Id = id;
            Naam = naam;
            Beschrijving = beschrijving;
            GroepId = groepId;
        }

        public Project(string naam, string beschrijving, int groepId)
        {
            Naam = naam;
            Beschrijving = beschrijving;
            GroepId = groepId;
        }
        public Project(ProjectDTO dto)
        {
            Id = dto.Id;
            Naam = dto.Naam;
            Beschrijving = dto.Beschrijving;
            GroepId = dto.GroepId;
        }
        public ProjectDTO GetDTO()
        {
            ProjectDTO dto = new(Id, Naam, Beschrijving, GroepId);
            return dto;
        }
        public Project()
        {

        }
        public override string ToString()
        {
            return $"Projectnaam: {this.Naam}\n  Projectbeschrijving: {this.Beschrijving}";
        }
    }
}
