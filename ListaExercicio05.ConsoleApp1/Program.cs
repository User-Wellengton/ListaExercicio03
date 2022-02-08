using System;

namespace ExercicioLista05.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 5:
            //• Escreva um algoritmo que leia um valor inicial A e imprima a sequência de
            //valores do cálculo de A! e o seu resultado. 
            //Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
            //• Pesquise sobre “fatorial"
            
            int i, n, fatorial;
            
            Console.WriteLine("Digite um valor: ");
            n = Convert.ToInt32(Console.ReadLine());

            fatorial = n;
            string x = n + "! = " + n;

            for (i = n - 1; i >=1; i --)
            {
                fatorial = fatorial * i;
                x = x + " X " + i ;
            }


            Console.WriteLine("\nFatorial de: " + x +" = "+ fatorial);
            



        }
    }
}
