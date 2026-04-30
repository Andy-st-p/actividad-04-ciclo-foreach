using System.Diagnostics.Metrics;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Contar cuántos valores cumplen una condición dada por el usuario.
            int[] numeros = { 1, 6, 11, 15, 5, 16, 25 };
            int contador = 0;
            
            foreach (int numero in numeros)
            {
                if (numero > 10)
                {
                    contador++;
                }
            }

            Console.WriteLine($"Cantidad de valores que cumplen la condición son: {contador}");
        }
    }
}
