﻿using System;

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
            Vypis();


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
                            for (int k = -1; k != 2; k++)
                            {
                                for (int l = -1; l != 2; l++)
                                {
                                    if (j + k >=0 && j + k < x && i + l >=0 && i + l <y)
                                    {
                                        if (HraciPole[j + k, i + l] == 9)
                                        {
                                            sousedi++;
                                        }
                                    }
                                }

                            }
                            HraciPole[j, i] = sousedi;
                        }
                    };
                };
            };


            void Vypis()
            {
                for (int j = 0; j < x; j++)
                {
                    for (int i = 0; i < y; i++)
                    {
                        Console.Write(HraciPole[j, i]);
                    }
                    Console.WriteLine();
                }
            }    
        }
    }
}
