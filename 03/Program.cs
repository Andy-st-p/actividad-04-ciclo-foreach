using System.Diagnostics.Metrics;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Contar cuántos valores de una colección son mayores que 50.
            int[] numeros = { 1, 52, 3, 54, 5, };
            int contador = 0;
            foreach (int numero in numeros)
            {
                if (numero > 50)
                {
                    contador++;
                }
            }
            Console.WriteLine(contador);
        }
    }
}
