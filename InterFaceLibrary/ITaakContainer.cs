namespace InterFaceLibrary
{
    public interface ITaakContainer
    {
        public List<TaakDTO> FindByPersoonInGroep(int groepId, int persoonId);
        public TaakDTO FindById(int taakId);
        public void Delete(int taakId);
        public void Create(TaakDTO taak);
        public void Update(TaakDTO taak);
        public List<TaakDTO> FindByPersoon(int persoonId);

    }
}