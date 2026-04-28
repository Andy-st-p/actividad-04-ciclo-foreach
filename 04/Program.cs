using System.Diagnostics.Metrics;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Contar cuántos números de una colección son pares.
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int contador = 0;
            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    contador++;
                }
            }
            Console.WriteLine(contador);
        }
    }
}
