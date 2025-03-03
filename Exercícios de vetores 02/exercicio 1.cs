int[] vet;
int i, num, soma_par = 0, quantidade_pares = 0;
double media;

Console.WriteLine("Digite o tamanho do vetor");
num = int.Parse(Console.ReadLine());
vet = new int[num];

Console.WriteLine($"Digite {num} números");
for (i = 0; i < num; i++)
{
    vet[i] = int.Parse(Console.ReadLine());
}

for (i = 0; i < num; i++)
{
    if (vet[i] % 2 == 0)
    {
        soma_par += vet[i];
        quantidade_pares++;
    }
}

if (quantidade_pares > 0)
{
    media = (double)soma_par / quantidade_pares;
    Console.WriteLine($"A média dos números pares é: {media}");
}
else
{
    Console.WriteLine("Não há números pares para calcular a média.");
}