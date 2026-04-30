using System.Diagnostics.Metrics;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Contar cuántos valores son divisibles entre 5.
            int[] numeros = { 1, 6, 11, 15, 5, 16, 25 };

            foreach (int numero in numeros)
            {
                if (numero % 5 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
