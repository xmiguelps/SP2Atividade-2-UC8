List<string> produtos = new List<string>();
string txt = "";
Console.WriteLine("Escreva seus produtos para adicionar na lista: ");
Console.WriteLine("Digite 'fim' para finalizar a lista");
Console.WriteLine("-------------------------------");
Console.WriteLine("Digita seus produto: ");
while (txt != "fim")
{
    Console.Write("--> ");
    txt = Console.ReadLine();
    if (txt != "fim")
    {
        produtos.Add(txt);
    }
}
produtos.Sort();
Console.WriteLine("Produtos que começam com 'A':");
foreach (string produto in produtos)
{
    if (produto.StartsWith("a") || produto.StartsWith("A"))
    {
        Console.WriteLine(produto);
    }
}