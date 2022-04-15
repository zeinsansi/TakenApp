namespace InterFaceLibrary
{
    public interface IPersoonContainer
    {
        public List<PersoonDTO> FindByGroepId(int groepId);
        public void Create(PersoonDTO persoon, string newWachtwoord);
        public PersoonDTO LogIn(string gebruikersnaam, string wachtwoord);
        public PersoonDTO FindByID(int id);
    }
}