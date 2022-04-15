namespace InterFaceLibrary
{
    public interface IPersoonContainer
    {
        public List<PersoonDTO> FindByGroepId(int groepId);
        public void Create(PersoonDTO persoon);
        public PersoonDTO LogIn(string gebruikersnaam, string wachtwoord);
    }
}