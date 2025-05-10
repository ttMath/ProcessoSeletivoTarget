Console.WriteLine("Escreva uma palavra para ser invertida.");
string original = Console.ReadLine()!;

string invertida = string.Empty;
for (int i = original.Length - 1; i >= 0; i--)
{
    invertida += original[i];
}

Console.WriteLine($"String original: {original}");
Console.WriteLine($"String invertida: {invertida}");