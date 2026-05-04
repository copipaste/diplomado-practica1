// ===========================================
// Juego: Adivina el Número
// Proyecto: DemoDevOps - Práctica CI/CD
// ===========================================

Console.WriteLine("========================================");
Console.WriteLine("ADIVINA EL NÚMERO");
Console.WriteLine("========================================");
Console.WriteLine("He pensado en un número del 1 al 100.");
Console.WriteLine("¡Intenta adivinarlo!\n");

Random random = new();
int numeroSecreto = random.Next(1, 101);
int intentos = 0;
bool adivinado = false;

while (!adivinado)
{
    Console.Write("Ingresa tu número: ");
    string? entrada = Console.ReadLine();

    if (!int.TryParse(entrada, out int intento))
    {
        Console.WriteLine("Por favor, ingresa un número válido.\n");
        continue;
    }

    if (intento < 1 || intento > 100)
    {
        Console.WriteLine("El número debe estar entre 1 y 100.\n");
        continue;
    }

    intentos++;

    if (intento < numeroSecreto)
    {
        Console.WriteLine("¡Es más ALTO! Sigue intentando.\n");
    }
    else if (intento > numeroSecreto)
    {
        Console.WriteLine("¡Es más BAJO! Sigue intentando.\n");
    }
    else
    {
        adivinado = true;
        Console.WriteLine("\n========================================");
        Console.WriteLine($"¡FELICIDADES! Adivinaste el número {numeroSecreto}");
        Console.WriteLine($"Lo lograste en {intentos} intento(s).");
        Console.WriteLine("========================================");

        if (intentos <= 5)
            Console.WriteLine("¡Increíble! Eres un experto.");
        else if (intentos <= 10)
            Console.WriteLine("¡Muy bien! Buen trabajo.");
        else
            Console.WriteLine("¡Lo lograste! Sigue practicando.");
    }
}

