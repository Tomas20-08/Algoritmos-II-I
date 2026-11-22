namespace CaraCruz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cara o Cruz");

            int victorias = 0;
            int derrotas = 0;

            while (true)
            {
                Console.WriteLine("¿Listo?");
                Console.WriteLine("¡Vamos!");

                string eleccion = ElegirLado();
                Console.WriteLine($"Usted eligió: {eleccion}");

                string resultado = LanzarMoneda();
                Console.WriteLine($"La moneda cayó en: {resultado}");

                if (eleccion == resultado)
                {
                    Console.WriteLine("¡Ganó!");
                    victorias++;
                }
                else
                {
                    Console.WriteLine("¡Perdió!");
                    derrotas++;
                }

                Console.WriteLine("¿Desea jugar de nuevo?");
                Console.WriteLine("Digite S para jugar de nuevo o N para salir");
                string? jugarDeNuevo = Console.ReadLine();
                if (jugarDeNuevo?.ToLower() == "n")
                {
                    break;
                }
            }

            Console.WriteLine($"Victorias: {victorias} - Derrotas: {derrotas}");
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }

        static string ElegirLado()
        {
            Console.WriteLine("Elija: [1] Cara - [2] Cruz");
            string? entrada = Console.ReadLine();

            while (entrada != "1" && entrada != "2")
            {
                Console.WriteLine("Usted digito una opcion invalida, Digite Nuevamente");
                entrada = Console.ReadLine();
            }

            return entrada == "1" ? "Cara" : "Cruz";
        }

        static string LanzarMoneda()
        {
            Random random = new Random();
            int lado = random.Next(0, 2);
            return lado == 0 ? "Cara" : "Cruz";
        }
    }
}
