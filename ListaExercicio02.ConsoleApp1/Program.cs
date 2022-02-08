using System;

namespace ListaExercicio02.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] numeros = new int[100];

            int n = 0;

            for (int a = 100; a < 200; a++)
            {
                numeros[n] = a;
                n++;

            }

            foreach (int i in numeros)
            {
                
                if (i % 2 != 0) 
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
