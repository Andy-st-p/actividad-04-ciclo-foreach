using System.ComponentModel;
using System.Numerics;
using System.Runtime.ConstrainedExecution;

namespace _25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determinar si la colección cumple con una regla definida(por ejemplo, no contener ceros).
            int[] numeros = { 1, 6, 11, 15, 5, 16, 25, 0 };
            bool cumpleRegla = false;

            foreach (int numero in numeros)
            {
                if (numero == 0)

                {
                    cumpleRegla = false;
                }
                else if (numero != 0)
                {
                    cumpleRegla = true;
                }
            }
            Console.WriteLine(" la condicion es : " + cumpleRegla);
        }
    }
}
