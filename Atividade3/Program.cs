using Atividade3.Model;
using System.Text.Json;


IEnumerable<DiaFaturamento>? dados = JsonSerializer.Deserialize<IEnumerable<DiaFaturamento>>(File.ReadAllText(@"..\..\..\Data\dados.json"));

if (dados == null || !dados.Any())
{
    Console.WriteLine("Nenhum dado de faturamento encontrado.");
    return;
}

List<double> faturamentos = [.. dados
    .Where(d => d.Valor > 0)
    .Select(d => d.Valor)];

if (faturamentos.Count == 0)
{
    Console.WriteLine("Não houve faturamento em nenhum dia do mês.");
    return;
}

double menor = faturamentos.Min();
double maior = faturamentos.Max();
double media = faturamentos.Average();
int diasAcimaDaMedia = faturamentos.Count(v => v > media);

Console.WriteLine($"Menor faturamento do mês: R${menor:F2}");
Console.WriteLine($"Maior faturamento do mês: R${maior:F2}");
Console.WriteLine($"Dias com faturamento acima da média ({media:F2}): {diasAcimaDaMedia}");