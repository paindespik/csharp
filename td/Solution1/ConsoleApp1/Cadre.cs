using System;


namespace ConsoleApp1
{
    public class Cadre : Personne
    {
        private double prime;

        public Cadre(int id, string nom, string prenom, DateTime dateDeNaissance, double salaireBrut, Service service, double prime) : base(id, nom, prenom, dateDeNaissance, salaireBrut, service)
        {
            Prime=prime;
        }
        public double Prime{
            get{
                return prime;
            }
            private set{
                if(value>0 && value<6000)
                    prime=value;
            }
        }

        public override double SalaireNet{
            get {return (salaireBrut+prime)*0.75;}
        }
        
        public override string Identite{
            get { return string.Format("{0}, {1}, {2}, {3} ans, {4:C}, service : {5}, {6:C}", id, nom, prenom, Age, SalaireNet, service.Libelle, prime ); }
        }
    }
}