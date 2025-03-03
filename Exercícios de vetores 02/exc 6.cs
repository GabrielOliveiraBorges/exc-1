Console.Write("Digite a quantidade de pessoas: ");
int qtd = int.Parse(Console.ReadLine());

string[] nome = new string[qtd];
int[] idade = new int[qtd];
int maior_idade = 0;
string mais_velho = "";

for (int i = 0; i < qtd; i++)
{
    Console.Write($"Digite o nome da {i + 1}ª pessoa: ");
    nome[i] = Console.ReadLine();

    Console.Write($"Digite a idade de {nome[i]}: ");
    idade[i] = int.Parse(Console.ReadLine());

    if (idade[i] > maior_idade)
    {
        maior_idade = idade[i];
        mais_velho = nome[i];
    }
}

Console.WriteLine($"A pessoa mais velha é: {mais_velho}");