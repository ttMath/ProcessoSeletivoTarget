using System.Text.Json;

string json = @"
        {
            ""SP"": 67836.43,
            ""RJ"": 36678.66,
            ""MG"": 29229.88,
            ""ES"": 27165.48,
            ""Outros"": 19849.53
        }";

var faturamento = JsonSerializer.Deserialize<Dictionary<string, double>>(json);

if (faturamento == null)
{
    Console.WriteLine("Erro ao processar os dados.");
    return;
}

double total = 0;
foreach (var valor in faturamento.Values)
{
    total += valor;
}

Console.WriteLine("Percentual de representação por estado:");
foreach (var estado in faturamento)
{
    double percentual = (estado.Value / total) * 100;
    Console.WriteLine($"{estado.Key}: {percentual:F2}%");
}