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
        /// <summary>
        /// Constructor voor TaakContainer met een ITaakContainer
        /// </summary>
        /// <param name="container">ITaakContainer</param>
        public TaakContainer(ITaakContainer container)
        {
            this.container = container;
        }
        /// <summary>
        /// Zoekt een taak op van een bepaalde persoon in een bepaalde groep
        /// </summary>
        /// <param name="groepId"></param>
        /// <param name="persoonId"></param>
        /// <returns>List van taken</returns>
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
        /// <summary>
        /// Verwijdert een taak
        /// </summary>
        /// <param name="taak">Taak</param>
        public void Delete(int taakId)
        {
            container.Delete(taakId);
        }
        /// <summary>
        /// Voegt een taak toe
        /// </summary>
        /// <param name="taak">Taak</param>
        /// <param name="groepId">Groep Id</param>
        /// <param name="persoonId">Persoon Id</param>
        public void Create(Taak taak)
        {
            TaakDTO dto = taak.GetDTO();
            container.Create(dto);
        }
        public void Update(Taak taak)
        {
            TaakDTO dto = taak.GetDTO();
            container.Update(dto);
        }
        public Taak FindById(int taakId)
        {
            TaakDTO dto = container.FindById(taakId);
            return new Taak(dto);
        }
    }
}
