using System;

namespace ConsoleApp1
{
    public class Personne
    {
        protected int id;
        protected string nom;
        protected string prenom;
        protected DateTime dateDeNaissance;
        protected double salaireBrut;
        protected Service service;

        public Personne(int id, string nom, string prenom, DateTime dateDeNaissance) : this(id, nom, prenom, dateDeNaissance, new Service(0,"billi"))
        {
        }
        public Personne(int id, string nom, string prenom, DateTime dateDeNaissance, double salaireBrut) : this(id, nom, prenom, dateDeNaissance, salaireBrut, new Service(0,"billi") )
        {
        }
        public Personne(int id, string nom, string prenom, DateTime dateDeNaissance, Service service) : this(id, nom, prenom, dateDeNaissance, 0, service)
        {
        }

        public Personne(int id, string nom, string prenom, DateTime dateDeNaissance, double salaireBrut, Service service)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            DateDeNaissance = dateDeNaissance;
            SalaireBrut = salaireBrut;
            Service = service;

        }


        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        public string Nom
        {
            get { return nom; }
            private set { nom = value; }
        }

        public string Prenom
        {
            get => prenom;
            private set => prenom = value;
        }

        public DateTime DateDeNaissance
        {
            get => dateDeNaissance;
            private set => dateDeNaissance = value;
        }

        public double SalaireBrut
        {
            get => salaireBrut;
            set => salaireBrut = value;
        }

        public string Adresse
        {
            get;
            set;
        }
        
        public int Age
        {
            get
            {
                // Le calcul n'est pas très précis mais ça fonctionne ...
                return (int)Math.Floor(DateTime.Now.Subtract(DateDeNaissance).TotalDays / 365);
            }
        }

        virtual public double SalaireNet
        {
            get { return SalaireBrut * 0.8; }
        }

        virtual public string Identite
        {
            get { return string.Format("{0}, {1}, {2}, {3} ans, {4:C}, service : {5}", id, nom, prenom, Age, SalaireNet, service.Libelle); }
        }

        public Service Service
        {
            get => service;


            private set
            {
                if (value != null)
                {
                    service = value;
                }
                else
                {
                    service=new Service(0, "billi");
                }
                
            } 

        }
    }
}