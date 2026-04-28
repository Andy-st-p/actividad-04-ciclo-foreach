namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular el promedio de los valores almacenados en una colección.
            int[] numeros = { 4, 4, 5, 6  };
            int suma = 0;
            foreach (int numero in numeros)
            {
                suma += numero;
            }
            double promedio = (double)suma / numeros.Length;
            Console.WriteLine(promedio);
        }
    }
}
