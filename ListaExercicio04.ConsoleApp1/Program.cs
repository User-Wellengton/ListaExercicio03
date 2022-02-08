using System;

namespace ListaExercicio04.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

                    // • Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e
                        //calcule a tabuada de N.
                //• Mostre a tabuada na forma: 0 x N = 0, 1 x N = 1N, 2 x N = 2N, ..., 10 x N =
                //10N.

        {

            int resultado;

            Console.WriteLine("Digite um valor entrre 1 e 10:");
            int n = Convert.ToInt32(Console.ReadLine());    

            for (int a = 0; a < 11; a++)
            {
               resultado = n * a;

                Console.WriteLine(a + " x " + n +" = "+resultado);
            }

            
        }
    }
}
