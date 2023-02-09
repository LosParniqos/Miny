using System;

namespace Miny
{
    class Program
    {
        static void Main(string[] args)
        {
            Random nahoda = new Random();
            int x = 10;
            int y = 10;
            int PocetMin = 10;
            int[,] HraciPole = new int[x, y];




            void Generace()
            {
                for (int k = 0; k < PocetMin; k++)
                {
                    (int i, int j) = (nahoda.Next(x), nahoda.Next(y));
                    while (HraciPole[i, j] == 9)
                    {
                        (i, j) = (nahoda.Next(x), nahoda.Next(y));
                    }
                    HraciPole[i, j] = 9;
                }
            }

            void logika()
            {
                for (int j = 1; j < sirka - 1; j++)
                {
                    for (int i = 1; i < delka - 1; i++)
                    {
                        int sousedi = 0;
                        for (int x = -1; x != 2; x++)
                        {
                            for (int y = -1; y != 2; y++)
                            {
                                if ((bakterie[j + x, i + y] == 1) && !(x == 0 && y == 0))
                                {
                                    sousedi++;
                                }
                            }
                        
                        }
                    };
                };
            }





        }
    }
}
