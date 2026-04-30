using System.Drawing;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verificar si existe al menos un valor negativo en la colección.
            int [] numeros = { 4, -6, 9 };
            bool existeNegativo = false;
            
            foreach (int numero in numeros)
            {
                if (numero < 0)
                {
                    existeNegativo = true;
                    break;
                }
            }

            if (existeNegativo)
            {
                Console.WriteLine("Existe al menos un valor negativo.");
            }
            else
            {
                Console.WriteLine("No existen valores negativos.");
            }
        }
    }
}
