int[] vet;
int i, num, pares;

Console.WriteLine("Digite a quantidade de numeros");
num = int.Parse(Console.ReadLine());
vet = new int[num];

Console.WriteLine($"Digite {num} numeros");
for (i = 0; i < num; i++)
{
    vet[i] = int.Parse(Console.ReadLine());
}
pares = 0;

Console.WriteLine("Os numeros pares são: ");
for (i = 0; i < num; i++)
{
    if (vet[i] % 2 == 0)
    {
        Console.WriteLine(vet[i]);
        pares++;
    }
}
Console.WriteLine($"a quantidade de numeros pares é {pares}");