namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar todos los valores que sean múltiplos de 3.
            int[] numeros ={ 1, 2, 3, 4, 5, 6, 9, 12, 13 };
            foreach (int numero in numeros)
            {
                if (numero % 3 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
