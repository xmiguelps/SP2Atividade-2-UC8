Console.WriteLine("Digite quantos numeros positivos quiser para ver a soma deles");
int num1 = 0;
int num2 = 0;
int num = 0;
int res = 0;
Console.Write("Digite o primeiro numero: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo numero: ");
num2 =int.Parse(Console.ReadLine());
res = num1 + num2;
while (num >= 0)
{
    Console.WriteLine($"O resultado é: {res}");
    Console.Write("Digite outro numero: ");
    num = int.Parse(Console.ReadLine());
    res += num;
    if (num < 0)
    {
        Console.WriteLine("Não é possivel adicionar numeros negativos!!");
    }
}
