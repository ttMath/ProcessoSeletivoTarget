using Atividade2;

Console.Write("Informe um número: ");

if (!int.TryParse(Console.ReadLine(), out int numero))
{
    Console.WriteLine("Entrada inválida. Por favor, apenas números.");
    return;
}

if (!Fibonacci.PertenceFibonacci(numero))
{
    Console.WriteLine($"{numero} Não pertence à sequência de Fibonacci.");
    return;
}

Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");