int i = 1;
int pares = 0;
int impars = 0;

int[] numeros = new int[6];

Console.WriteLine("Insira 5 numeros");
while (i <= 5)
{
    Console.Write($"{i}° Numero: ");
    numeros[i] = int.Parse(Console.ReadLine());
    if (numeros[i] == 0)
    {
        Console.WriteLine("0 não pode ser digitado");
        break;
    }
    else if (numeros[i] % 2 == 0)
    {
        pares++;
    }
    else
    {
        impars++;
    }
    i++;
}

Console.WriteLine($"A quantidade de numeros pares foi {pares}");
Console.WriteLine($"A quantidade de numeros impares foi {impars}");