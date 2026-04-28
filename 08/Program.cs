using System.Drawing;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determinar el valor mayor contenido en una colección de números.
            int [] numeros = { 4, 5, 6, 7, 8, 9 };
            int mayor = numeros[0];
            foreach (int numero in numeros)
            {
                if (numero > mayor)
                {
                    mayor = numero;
                }
            }
            Console.WriteLine(mayor);
        }
    }
}
