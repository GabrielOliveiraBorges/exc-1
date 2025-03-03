int n = int.Parse(Console.ReadLine());
int[] numeros = Console.ReadLine().Split().Select(int.Parse).ToArray();

double soma = 0;
int count = 0;

foreach (int num in numeros)
{
 if (num % 2 == 0)
{
soma += num;
count++;
}
}

if (count > 0)
{
Console.WriteLine(soma / count);
}
else
{
Console.WriteLine("Nenhum número par.");
}
    