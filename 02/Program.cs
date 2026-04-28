namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular la suma de todos los números contenidos en una colección.
            int[] numerod = { 1, 2, 3, 4, 5, };
            int resultado = 0;
            foreach (int numero in numerod)
            {
                resultado += numero;
               
            }
            Console.WriteLine(resultado);
        }
    }
}
