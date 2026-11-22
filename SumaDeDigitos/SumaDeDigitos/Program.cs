class program
{
    static void Main()
    {
        Console.WriteLine("Número: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine($"Suma de dígitos = {sumaDigitos(n)}");
        }
        else
        {
            Console.WriteLine("Entrada invalida");
        }
    }

    static int sumaDigitos(int n)
    {
        n = Math.Abs(n);
        return n < 10 ? n : n % 10 + sumaDigitos(n / 10);
    }
}
