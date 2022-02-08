using System;

//Desenvolver um algoritmo que efetue a soma de todos os números 
//ímpares que são múltiplos de três e que se encontram no conjunto dos 
//números de 1 até 500


namespace ListaExercicio03.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] numeros = new int[500];
            int soma = 0;

            int n = 0;

            for (int a = 1; a < 501; a++)
            {
                numeros[n] = a;
                n++;

            }

            foreach (int i in numeros)
            {

                if (i % 3 == 0 && i % 2 == 1)
                {
                    soma = soma + i;    
                     
                }
            }

            Console.WriteLine("\n"+soma);
             

        }
    }
}
