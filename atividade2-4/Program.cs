int num = 0;
Console.WriteLine("Escolha um numero e veremos se ele é primo");
while(num >= 0)
{
    Console.Write("Digite um numero: ");
    num = int.Parse(Console.ReadLine());
    int count = 0;
    for (int i = 1;i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            if (i == num / i)
            {
                count++;
            }
            else
            {
                count += 2;
            }
        }
    }
    if (num < 0)
    {
        Console.WriteLine("Não é possivel verificar numeros negativos!!");
    }
    else if (count == 2)
    {
        Console.WriteLine($"O numero {num} tem {count} divisores e é primo");
    }
    else
    {
        Console.WriteLine($"O numero {num} tem {count} divisores e não é primo");
    }
}
