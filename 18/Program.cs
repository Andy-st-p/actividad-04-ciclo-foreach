using System.Diagnostics.Metrics;

namespace _18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Contar cuántos valores son iguales a un número ingresado por el usuario.
            int[] numeros = { 1, 6, 11, 15, 5, 16, 25 };
            Console.Write("Ingrese un número: ");
            int numeroIngresado = int.Parse(Console.ReadLine());
            int contador = 0;

            foreach (int numero in numeros)
            {
                if (numero == numeroIngresado)
                {
                    contador++;
                }
            }

            Console.WriteLine($"Cantidad de valores iguales a {numeroIngresado}: {contador}");
        }
    }
}
