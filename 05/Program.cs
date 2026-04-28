namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar solo los valores positivos contenidos en una colección.
            int[] numeros = { -1, 22, -3,34, -5, 16, -74, 48, -95, 10 };
            foreach (int numero in numeros)
            {
                if (numero > 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
