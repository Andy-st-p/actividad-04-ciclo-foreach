namespace _21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determinar si la colección contiene valores repetidos.
            int[] numeros = { 1, 6, 11, 15, 5, 16, 25, 6 };
            bool tieneRepetidos = false;

            foreach (int numero in numeros)
            {
                if (numeros.Count(n => n == numero) > 1)
                {
                    tieneRepetidos = true;
                    break;
                }

            }
            
            if (tieneRepetidos)
            {
                Console.WriteLine("La colección contiene valores repetidos.");
            }
            else
            {
                Console.WriteLine("La colección no contiene valores repetidos.");
            }

        }
    }
}
