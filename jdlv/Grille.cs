using System;
using System.Collections.Generic;

namespace jdlv
{
    public class Grille
    {
        private int largeur;
        private int longueur;
        private int depart;
        public List<List<Cellule>> grille = new List<List<Cellule>>();

        public Grille(int largeur, int longueur, int depart)
        {
            Largeur = largeur;
            Longueur = longueur;
            Depart = depart;
            var rand = new Random();

            for (int i = 0; i < largeur; i++)
            {
                grille.Add(new List<Cellule>());
                for (int j = 0; j < longueur; j++)
                {
                    if (rand.Next(Longueur * Largeur) < depart)
                    {
                        grille[i].Add(new Cellule(true));
                    }
                    else
                    {
                        grille[i].Add(new Cellule(false));
                    }
                   
                }
            }
        }

        public int Largeur
        {
            get => largeur;
            set => largeur = value;
        }
        

        public int Longueur
        {
            get => longueur;
            set => longueur = value;
        }

        public int Depart
        {
            get => depart;
            set
            {
                if (value>0 && value<Longueur*Largeur)
                    depart = value;
            }
        }

        public void Afficher()
        {
            for (int i = 0; i < Longueur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    if (grille[i][j].Vivant == true)
                    {
                        Console.Write("#");   
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}