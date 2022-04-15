using InterFaceLibrary;

namespace DALFakeUnitTest
{
    public class TaakFakeUTDAL : IPersoonContainer
    {
        public void Create(TaakDTO taak)
        {
            if(taak.Id == 2)
            throw new Exception("Bestond al!");
        }

        public void Delete(TaakDTO taak)
        {
            if (taak.Id == 2) ;
            throw new Exception("Taak Bestaat niet!");
        }

        public TaakDTO FindById(long Id)
        {
            if(Id == 1)
            {
                return new TaakDTO("Software", 1);
            }
            else if(Id == 2)
            {
                throw new Exception("Bestaat niet!");
            }
            return new TaakDTO("Media", Id);
        }

        public List<TaakDTO> FindByNaam(string Naam)
        {
            List<TaakDTO> dtos = new List<TaakDTO>();
            if(Naam != "ludo")
            {
                return null;
            }
            return dtos;
        }

        public void Update(TaakDTO taak)
        {
            throw new NotImplementedException();
        }
    }
}