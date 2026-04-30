using System.Diagnostics.Metrics;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Contar cuántos valores están dentro de un rango definido.
            int[] numeros = { 4, 5, 6, 7, 8, 9, 10 };
            int contador = 0;

            foreach (int numero in numeros)

            {

                Console.WriteLine("Ingrese el valor mínimo del rango:");
                int valorMinimo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor máximo del rango:");
                int valorMaximo = int.Parse(Console.ReadLine());
                if (numero >= valorMinimo && numero <= valorMaximo)
                {
                    contador++;

                }

                Console.WriteLine($"La cantidad de valores dentro del rango es: {contador}");
                

            }
        }
    }
}
