using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceLibrary
{
    public interface IProjectContainer
    {
        public void Create(ProjectDTO projectDTO);
        public void Update(ProjectDTO projectDTO);
        public void Delete(ProjectDTO projectDTO);
        public ProjectDTO GetProject(int id);
        public ProjectDTO FindByGroep(int groepId);
    }
}
