using System.Globalization;

double[] temps = new double[7];
double total = 0;

Console.WriteLine("Vamos verificar a média de temperatura dessa semana");
for (int i = 1;i <= 7;i++)
{
    Console.Write($"Insira a temperatura do {i}° dia: "); 
    temps[i-1] = double.Parse(Console.ReadLine());
}

foreach (double temp in temps)
{
    total += temp;
}
double media = total / 7;
foreach (double temp in temps)
{
    if (temp > media)
    {
        Console.Write($"{temp}, ");
    }    
}
Console.Write($"foram as temperatures maiores que a média({media:0.0})");
