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

            Personne p1 = new Personne(1, "DUPONT", "Charles", new DateTime(1998, 04, 12));
            Personne p2 = new Personne(2, "KERBAN", "Henry", new DateTime(1981, 09, 24), 1500);
            Personne p3 = new Personne(3, "CHAMPOT", "Paul", new DateTime(1981, 09, 17), 1500);
            Personne p4 = new Personne(4, "JOULIE", "Alexandre", new DateTime(1987, 11, 21), 2100);
            
            Entreprise e1 = new Entreprise();
/*
            Console.WriteLine(p1.Identite);
            Console.WriteLine(p2.Identite);
            Console.WriteLine(p3.Identite);
            Console.WriteLine(p4.Identite);
*/
            e1.AjouterPersonne(p1);
            e1.AjouterPersonne(p2);
            e1.AjouterPersonne(p3);
            e1.AjouterPersonne(p4);
           // e1.AfficherPersonne();
           Service serv=new Service(0, "billi");
           e1.RechercherParService(serv);

        }
    }
}