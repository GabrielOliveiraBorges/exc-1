Console.Write("Digite a quantidade de alunos: ");
int qtd = int.Parse(Console.ReadLine());

string[] nome = new string[qtd];
double[] nota1 = new double[qtd];
double[] nota2 = new double[qtd];

for (int i = 0; i < qtd; i++)
{
    Console.Write($"Digite o nome do {i + 1}º aluno: ");
    nome[i] = Console.ReadLine();

    Console.Write($"Digite a nota do 1º semestre de {nome[i]}: ");
    nota1[i] = double.Parse(Console.ReadLine());

    Console.Write($"Digite a nota do 2º semestre de {nome[i]}: ");
    nota2[i] = double.Parse(Console.ReadLine());
}

Console.WriteLine("Alunos aprovados:");
for (int i = 0; i < qtd; i++)
{
    double media = (nota1[i] + nota2[i]) / 2.0;
    if (media >= 6.0)
    {
        Console.WriteLine(nome[i]);
    }
}