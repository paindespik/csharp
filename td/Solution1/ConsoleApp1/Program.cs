using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Afficher les accents et autres caractères
            Console.OutputEncoding = Encoding.UTF8;
            Service production = new Service(1, "production");
            Service comptabilité = new Service(2, "comptatibilité");
            Service direction = new Service(3, "direction");


            Employe p1 = new Employe(1, "DUPONT", "Charles", new DateTime(1998, 04, 12), 1500, production, 14);
            Employe p2 = new Employe(2, "KERBAN", "Henry", new DateTime(1991, 09, 24), 1500, production, 7);
            Employe p3 = new Employe(3, "CHAMPOT", "Paul", new DateTime(1991, 03, 17), 1500, production, 6);
            Cadre c1 = new Cadre(4, "JOULIE", "Alexandre", new DateTime(1987, 11, 21), 2100, comptabilité, 100);
            Cadre c2 = new Cadre(5, "Mitaut", "Marcel", new DateTime(1972, 10, 6), 6000, direction, 2000);
            
            
            Entreprise e1 = new Entreprise();
/*
            Console.WriteLine(p1.Identite);
            Console.WriteLine(p2.Identite);
            Console.WriteLine(p3.Identite);*/
           // Console.WriteLine(p4.Identite);

            e1.AjouterPersonne(p1);
            e1.AjouterPersonne(p2);
            e1.AjouterPersonne(p3);
            e1.AjouterPersonne(c1);
            e1.AjouterPersonne(c2);
            e1.AfficherPersonne();
           
           //e1.RechercherPersonnesCommencePar("K");

        }
    }
}