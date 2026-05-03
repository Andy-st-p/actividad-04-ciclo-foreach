namespace _23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verificar si todos los valores están dentro de un rango válido.
            int[] numeros = { 1, 6, 10, 155, 5, 16, 2 };
            int min = 1;
            int max = 20;
            bool todosValidos = true;

            foreach (int numero in numeros)
            {
                if (numero < min || numero > max)
                {
                    todosValidos = false;
                    break;
                }
            }

            if (todosValidos)
            {
                Console.WriteLine("Todos los valores están dentro del rango válido.");
            }
            else
            {
                Console.WriteLine("Algunos valores están fuera del rango válido.");
            }
        }
    }
    }