int[] vetA;
int[] vetB;
int[] vetC;
int num_A, num_B, num_C, numeros, i, soma = 0;

Console.WriteLine("Digite a quantidade de numeros");
numeros = int.Parse(Console.ReadLine());
vetA = new int[numeros];
vetB = new int[numeros];
vetC = new int[numeros];

Console.WriteLine($"Digite {numeros} para o vetor A");
for (i = 0; i < numeros; i++)
{

    vetA[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Digite {numeros} para o vetor B");
for (i = 0; i < numeros; i++)
{
    vetB[i] = int.Parse(Console.ReadLine());
}

for (i = 0; i < numeros; i++)
{
    vetC[i] = vetA[i] + vetB[i];

    Console.WriteLine("O Resultado das somas é ");
    Console.WriteLine(vetC[i]);
}
















