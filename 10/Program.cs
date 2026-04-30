namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verificar si un número específico se encuentra dentro de una colección.
            int[] numeros = { 4, 5, 6, 7, 8, 9 };
            int numeroBuscado;
            bool encontrado = false;

            Console.WriteLine("Ingrese el número que desea buscar:");
            numeroBuscado = int.Parse(Console.ReadLine());
             
            foreach (int numero in numeros)
            {
                if (numero == numeroBuscado)
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                Console.WriteLine("El número {0} se encuentra en la colección.", numeroBuscado);
            }
            else
            {
                Console.WriteLine("El número {0} no se encuentra en la colección.", numeroBuscado);
            }
        }
    }
}
