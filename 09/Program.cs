using System.Drawing;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determinar el valor menor contenido en una colección de números.
            int [] numeros = { 4, 5, 6, 7, 8, 9 };
            int menor = numeros[0];
                        foreach (int numero in numeros) 
            {
                if (numero < menor)
                {
                    menor = numero;
                }
            }
            Console.WriteLine(menor);
        }
    }
}
