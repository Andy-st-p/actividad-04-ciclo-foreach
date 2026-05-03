namespace _19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular la suma solo de los valores pares contenidos en la colección.
            int[] numeros = { 4, 6, 9, 10, 8 };
            int suma = 0;
            foreach (int numero in numeros)
            {
                if (numero %2 ==0)
                { suma += numero ;
                }
            }
            Console.WriteLine($"Suma de los valores pares es: {suma}");
           
        }
    }
}
