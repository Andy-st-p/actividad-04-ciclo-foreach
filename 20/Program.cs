namespace _20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar los valores que no cumplen una condición específica.
            int[] numeros = { 1, 6, 11, 15, 5, 16, 25 };
            int numeroIngresado = 10;
            
            foreach (int numero in numeros)
            {
                if (numero != numeroIngresado)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
