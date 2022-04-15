namespace InterFaceLibrary
{
    public interface ITaakContainer
    {
        public List<TaakDTO> FindByPersoonInGroep(int groepId, int persoonId);
        public void Delete(TaakDTO taak);
        public void Create(TaakDTO taak, int groepId, int persoonId);

    }
}