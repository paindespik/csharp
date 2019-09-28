using System;

namespace jdlv
{
    public class Simulation
    {
        private Grille plateau = new Grille(initialiserLargeur(), initialiserLongueur(), initialiserDebut());
        public Simulation()
        {
            
        }

        public void Tour()
        {
            for(int i=0; i<plateau.Largeur; i++)
            {
                for (int j = 0; j < plateau.Longueur; j++)
                {
                    int nbAlentour=0;
                    if (i != 0)
                    {
                        if (plateau.grille[i-1][j].Vivant == true)
                        {
                            nbAlentour++;
                        }
                    }
                    if (j != 0)
                    {
                        if (plateau.grille[i][j-1].Vivant == true)
                        {
                            nbAlentour++;
                        }
                    }
                    if (i != plateau.Largeur-1)
                    {
                        if (plateau.grille[i+1][j].Vivant == true)
                        {
                            nbAlentour++;
                        }
                    }
                    if (j != plateau.Longueur-1)
                    {
                        if (plateau.grille[i][j+1].Vivant == true)
                        {
                            nbAlentour++;
                        }
                    }
                    if (i != 0 && j!=0)
                    {
                        if (plateau.grille[i-1][j-1].Vivant == true)
                        {
                            nbAlentour++;
                        }
                    }
                    if (i != 0 && j<plateau.Longueur-1)
                    {
                        if (plateau.grille[i-1][j+1].Vivant == true)
                        {
                            nbAlentour++;
                        }
                    }
                    if (i != plateau.Largeur-1 && j!=plateau.Longueur-1)
                    {
                        if (plateau.grille[i+1][j+1].Vivant == true)
                        {
                            nbAlentour++;
                        }
                    }

                    if (i != plateau.Largeur - 1 && j != 0) 
                    {
                        if (plateau.grille[i+1][j+1].Vivant == true)
                        {
                            nbAlentour++;
                        }
                    }

                    if (plateau.grille[i][j].Vivant == true)
                    {
                        if(nbAlentour<)
                    }

                }
            }
        }    
        public static int initialiserLongueur()
        {
            Console.WriteLine("Qu'est doit etre la longueur du plateau? ");
            return Int32.Parse(Console.ReadLine());
        }
        public static int initialiserLargeur()
        {
            Console.WriteLine("Qu'est doit etre la largeur du plateau? ");
            return Int32.Parse(Console.ReadLine());
        }
        public static int initialiserDebut()
        {
            Console.WriteLine("Qu'est doit etre le nombre de cellules vivantes de départ ? ");
            return Int32.Parse(Console.ReadLine());
        }

        
        
        public Grille Grille
        {
            get => grille;
            private set => grille = value;
        }
    }
}