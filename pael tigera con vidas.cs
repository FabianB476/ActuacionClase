using System;

class Program
{
    static void Main()
    {
        int vidas = 3;
        Random random = new Random();

        do
        {
            Console.Clear();
            Console.WriteLine("Piedra, Papel o Tijera");
            Console.WriteLine($"Vidas: {vidas}");
            Console.Write("Elige (Piedra/Papel/Tijera): ");
            string jugador = Console.ReadLine().ToLower();

            if (jugador != "piedra" && jugador != "papel" && jugador != "tijera")
            {
                Console.WriteLine("Opción inválida, elige Piedra, Papel o Tijera.");
                continue;
            }

            string[] opciones = { "piedra", "papel", "tijera" };
            string computadora = opciones[random.Next(opciones.Length)];

            Console.WriteLine($"Computadora elige: {computadora}");

            if (jugador == computadora)
            {
                Console.WriteLine("Empate!");
            }
            else if ((jugador == "piedra" && computadora == "tijera") ||
                     (jugador == "papel" && computadora == "piedra") ||
                     (jugador == "tijera" && computadora == "papel"))
            {
                Console.WriteLine("¡Ganaste!");
            }
            else
            {
                Console.WriteLine("¡Perdiste!");
                vidas--;
            }

            if (vidas == 0)
            {
                Console.WriteLine("¡Se acabaron tus vidas! Fin del juego.");
                break;
            }

            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();

        } while (vidas > 0);
    }
}

