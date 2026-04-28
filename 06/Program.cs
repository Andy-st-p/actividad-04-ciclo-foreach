namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determinar cuántos valores negativos existen en una colección dada.
            int[] numeros = { -1, 22, -3, 34, -5, 16, -74, 48, -95, 10 };
            int contador = 0;
            foreach (int numero in numeros)
            {
                if (numero < 0)
                {
                    contador++;
                }
            }
            Console.WriteLine(contador);
        }
    }
}
