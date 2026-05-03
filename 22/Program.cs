using System.Diagnostics.Metrics;

namespace _22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Contar cuántos valores son mayores que un número ingresado.
            int[] numeros = { 1, 6, 11, 15, 5, 16, 25 };
            Console.WriteLine("ingrese un numero: ");
            int numeroIngresado = int.Parse(Console.ReadLine());
            int contador = 0;

            foreach (int numero in numeros)
            {
                if (numero > numeroIngresado)
                {
                    contador++;
                }
            }
            Console.WriteLine($"Cantidad de valores mayores a {numeroIngresado}: {contador}");
        }
        
    }
}
