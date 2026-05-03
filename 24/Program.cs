using System.Numerics;

namespace _24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar los valores que cumplen dos condiciones al mismo tiempo.
            int[] numeros = { 2, 3, 45, 65, 8, 4, 85 };
            int numeroIngresado1 = 5;
            int numeroIngresado2 = 50;

            foreach (int numero in numeros)
            {
                if (numero > numeroIngresado1 && numero < numeroIngresado2)
                {
                    Console.WriteLine(numero);
                }
            }

        }
    }
}
