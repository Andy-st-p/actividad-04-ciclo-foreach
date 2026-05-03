namespace _17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar únicamente los valores mayores al promedio de la colección.
            int[] numeros = { 4, 6, 9, 10, 8};
            double promedio = 0;
            
            foreach (int numero in numeros)
            {
                promedio += numero;
            }

            promedio /= numeros.Length;

            Console.WriteLine($"Promedio: {promedio}");
            Console.WriteLine("Valores mayores al promedio:");

            foreach (int numero in numeros)
            {
                if (numero > promedio)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
