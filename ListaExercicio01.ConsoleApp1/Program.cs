using System;

namespace ListaExercicio01.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


			decimal[] numeros = new decimal [15];

			for (int i = 0; i < numeros.Length; i++)
			{
				Console.Write("Digite sua altura: (ex : 1,10)");
				numeros[i] = Convert.ToDecimal(Console.ReadLine());
			}

			Array.Sort(numeros);
			Console.Write("\nMenor altura: " + numeros[0]);

			

			Console.Write("\nMaior altura: " + numeros[14]);
			
		}



	
        
    }
}
