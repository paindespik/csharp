using System.Collections.Generic;
using System;
namespace ConsoleApp1
{
    public class Entreprise
    {
        private List<Personne> liste=new List<Personne>();

        public bool AjouterPersonne(Personne personne)
        {
            if (personne != null)
            {
                if (liste.Contains(personne))
                {
                    return false;
                }
                liste.Add(personne);
                return true;
            }

            return false;

        }

        public bool ModifierPersonne(Personne personne)
        {
            int count = 0;
            foreach (Personne pers in liste)
            {
                
                if (pers.Id == personne.Id)
                {
                    liste[count] = personne;
                    return true;
                }

                count++;
            }

            return false;
        }

        public bool SuprrimerPersonne(Personne personne)
        {
            if (liste.Contains(personne))
            {
                liste.Remove(personne);
                return true;
            }

            return false;
        }

        public bool SupprimerPersonne(int id)
        {
            if (id >= 0 && id < liste.Count)
            {
                liste.Remove(liste[id]);
                return true;
            }

            return false;
        }

        public Personne RechercherPersonne(Personne personne)
        {
            foreach (Personne pers in liste)
            {
                if (pers == personne)
                {
                    return pers;
                }
            }

            return null;
        }

        public List<Personne> RechercherPersonnesCommencePar(string nom)
        {
            List<Personne> tris = new List<Personne>();
            foreach (Personne pers in liste)
            {
                var charA = pers.Nom.ToCharArray();
                var charB = nom.ToCharArray();

                if(charB.Length<=charA.Length)
                {
                    var i = 0;
                    for (i = 0; i < charB.Length; i++)
                    {
                        if (charA[i] != charB[i])
                            break;
                       
                    } 
                    if (i == charB.Length)
                    {
                        tris.Add(pers);
                    }
                }
            }

            foreach (Personne perstri in tris)
            {
                Console.WriteLine(perstri.Identite);
            }
            return tris;

        }
        public void AfficherPersonne()
        {
            foreach (var pers in liste)
            {
                Console.WriteLine(pers.Identite);
            }
        }
        public List<Personne> RechercherParService(Service service)
        {
            List<Personne> tris=new List<Personne>();
            foreach (Personne pers in liste)
            {
                if (pers.Service.Id == service.Id && pers.Service.Libelle==service.Libelle)
                {
                    tris.Add(pers);
                    Console.WriteLine(pers.Identite);
                }
            }
            return tris;
        }
    }
}