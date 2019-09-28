namespace jdlv
{
    public class Cellule
    {
        private bool vivant;

        public Cellule(bool vivant)
        {
            Vivant = vivant;
        }

        public bool Vivant
        {
            get => vivant;
            set => vivant = value;
        }
    }
}