int[] vetor;
int i, numeros, soma = 0;
double media;

Console.WriteLine("Digite o tamanho do vetor");
numeros = int.Parse(Console.ReadLine());
vetor = new int[numeros];

Console.WriteLine($"Digite {numeros} numeros");
for (i = 0; i < numeros; i++)
{
    vetor[i] = int.Parse(Console.ReadLine());
}

for (i = 0; i < numeros; i++)
{
    soma += vetor[i];
}

numeros = vetor.Length;

media = soma / numeros;

Console.WriteLine($"A média desses numeros é: {media}");
