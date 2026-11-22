namespace FibonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine("Secuencia Fibonacci hasta el " + n.ToString() + " término:");
            PrintFibonacciSequence(0, n, 0, 1);
            Console.WriteLine($"\nEl {n}º número de Fibonacci es: {Fibonacci(n)}");
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }

        static int Fibonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void PrintFibonacciSequence(int index, int n, int a, int b)
        {
            if (index >= n)
            {
                return;
            }
            Console.Write(a.ToString() + (index < n - 1 ? ", " : ""));
            PrintFibonacciSequence(index + 1, n, b, a + b);
        }
    }
}
