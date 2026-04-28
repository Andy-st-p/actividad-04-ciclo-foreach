namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar todos los valores contenidos en una colección de números ya definida.
            int[] numeros = { 1, 2, 3, 4, 5 };
            
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

        }
    }
}
