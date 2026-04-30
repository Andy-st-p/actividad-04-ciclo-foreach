namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determinar si todos los valores de la colección son positivos.
            int[] numeros = { 4, -6, 9 };
            bool sonPositivos = true;

            foreach (int numero in numeros)
            {
                if (numero <= 0)
                {
                    sonPositivos = false;
                    break;
                }
            }

            if (sonPositivos)
            {
                Console.WriteLine("Todos los valores son positivos.");
            }
            else
            {
                Console.WriteLine("No todos los valores son positivos.");
            }
        }
    }
}
