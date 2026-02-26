Console.Write("Até onde gostaria de ir na Série de Fibonacci? ");
List<int> nums = new List<int>();
int num = int.Parse(Console.ReadLine());
nums.Add(1);
Console.Write("0, 1, ");
for(int i = 1; i <= num ; i += nums[nums.Count() - 2])
{
    nums.Add(i);
    Console.Write($"{i}, ");
} 