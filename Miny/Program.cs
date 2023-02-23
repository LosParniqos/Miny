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
            Inicializace();
            Vypis();
            Zadavani();
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
                Console.Clear();
                Console.Write(" |");
                for (int a = 0; a < x; a++)
                {

                    Console.Write(a.ToString().PadLeft(3));
                }
                Console.WriteLine("\n-+--------------------------------------");
                for (int j = 0; j < x; j++)
                {
                    Console.Write(j+"|");
                    for (int i = 0; i < y; i++)
                    {
                        if (HraciPole[j, i] < 0 || HraciPole[j, i] ==10)
                        {
                            Console.Write("X".PadLeft(3));
                        }
                        else
                        {
                            Console.Write(HraciPole[j, i].ToString().PadLeft(3));
                        }
                    }
                    Console.WriteLine();
                }
            } 
            void Inicializace()
            {
                for (int j = 0; j < x; j++)
                {
                    for (int i = 0; i < y; i++)
                    {
                        HraciPole[j, i] = HraciPole[j, i] * (-1);
                        if (HraciPole[i, j] == 0)
                        {
                            HraciPole[i, j] = 10;
                        }
                    }
                }
            }
            void Zadavani()
            {
                Console.WriteLine("Napiš souřadnici X:");
                int UserX = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Napiš souřadnici Y:");
                int UserY = Int32.Parse(Console.ReadLine());
                Odkryvani(UserX,UserY);
            }
            void Odkryvani(int UserX, int UserY)
            {
                if (HraciPole[UserX, UserY] == 10)
                {
                    HraciPole[UserX, UserY] = 0;
                }
                else
                {
                    HraciPole[UserX, UserY] *= -1;
                }
            }
            void Rekurze()
            {
                
            }
        }
    }
}
