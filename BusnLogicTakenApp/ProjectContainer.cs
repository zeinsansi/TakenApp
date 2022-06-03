using InterFaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusnLogicTakenApp
{
    public class ProjectContainer
    {
        private readonly IProjectContainer container;
        public ProjectContainer(IProjectContainer container)
        {
            this.container = container;
        }
        public void Create(Project project)
        {
            ProjectDTO dto = project.GetDTO();
            container.Create(dto);
        }
        public void Update(Project project)
        {
            ProjectDTO dto = project.GetDTO();
            container.Update(dto);
        }
        public void Delete(Project projectDTO)
        {
            ProjectDTO dto = projectDTO.GetDTO();
            container.Delete(dto);
        }
        public Project GetProject(int id)
        {
            ProjectDTO dto = container.GetProject(id);
            return new Project(dto);
        }
        public Project FindByGroep(int groepId)
        {
            ProjectDTO dto = container.FindByGroep(groepId);
            return new Project(dto);
        }
    }
}
