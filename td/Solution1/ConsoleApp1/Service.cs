namespace ConsoleApp1
{
    public class Service
    {
        private int id;
        private string libelle;


        public Service(int id, string libelle)
        {
            Id = id;
            Libelle = libelle;
        }
        
        public int Id
        {
            get => id;
            private set => id = value;
        }

        public string Libelle
        {
            get => libelle;
            private set => libelle = value;
        }
    }
}