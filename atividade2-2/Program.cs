Random random = new Random();
int num = 0;
int random_num = random.Next(1, 101);
Console.WriteLine("Acerte o numero entre 1 e 100!!!");
do
{
    Console.Write("Digite o numero: ");
    num = int.Parse(Console.ReadLine());
    if (num != random_num)
    {
        Console.WriteLine("Errou, tente novamente");
    } else
    {
        Console.WriteLine("Parabens, voce acertou");
        break;
    }
} while (num != random_num);
