using System;


namespace ConsoleApp1
{
    public class Employe : Personne
    {
        private int nbRTT;

        public Employe(int id, string nom, string prenom, DateTime dateDeNaissance, double salaireBrut, Service service, int nbRTT) : base(id, nom, prenom, dateDeNaissance, salaireBrut, service)
        {
            NbRTT=nbRTT;
        }
        public int NbRTT{
            get{
                return nbRTT;
            }
            private set{
                if(value>0 && value <26){
                    nbRTT =value;
                }
            }
        }
        
        public override string Identite
        {
            get { return string.Format("{0}, {1}, {2}, {3} ans, {4:C}, service : {5}, {6} jours", id, nom, prenom, Age, SalaireNet, service.Libelle, nbRTT); }
        }

        
    }
}