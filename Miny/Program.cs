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


            Generace();
            logika();


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
                for (int j = 0; j < x; j++)
                {
                    for (int i = 0; i < y; i++)
                    {
                        if (HraciPole[j, i] != 9)
                        {
                            int sousedi = 0;
                            for (int x = -1; x != 2; x++)
                            {
                                for (int y = -1; y != 2; y++)
                                {
                                    if (j + x > -1 && j + x < 11 && i + j > -1 && i + j < 11)
                                    {
                                        if (HraciPole[j + x, i + j] == 9)
                                        {
                                            sousedi++;
                                        }
                                    }
                                }

                            }
                            HraciPole[x, j] = sousedi;
                        }
                    };
                };
            }





        }
    }
}
