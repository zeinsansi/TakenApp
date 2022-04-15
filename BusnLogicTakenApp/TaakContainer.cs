using InterFaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusnLogicTakenApp
{
    public class TaakContainer
    {
        private readonly ITaakContainer container;

        public TaakContainer(ITaakContainer container)
        {
            this.container = container;
        }
        public List<Taak> FindByPersoonInGroep( int groepId, int persoonId)
        {
            List<TaakDTO> dtos = container.FindByPersoonInGroep( groepId, persoonId);
            List<Taak> taken = new List<Taak>();
            foreach (TaakDTO dto in dtos)
            {
                taken.Add(new Taak(dto));
            }
            return taken;
        }
        public void Delete(Taak taak)
        {
            TaakDTO dto = taak.GetDTO();
            container.Delete(dto);
        }
        public void Create(Taak taak, int groepId, int persoonId)
        {
            TaakDTO dto = taak.GetDTO();
            container.Create(dto, groepId, persoonId);
        }
    }
}
