Console.Write("Digite a quantidade de pessoas: ");
int qtd = int.Parse(Console.ReadLine());

double[] altura = new double[qtd];
char[] sexo = new char[qtd];
double maior_altura = double.MinValue;
double menor_altura = double.MaxValue;
double soma_f = 0;
int qtd_m = 0, qtd_f = 0;

for (int i = 0; i < qtd; i++)
{
    Console.Write($"Digite a altura da {i + 1}ª pessoa: ");
    altura[i] = double.Parse(Console.ReadLine());

    Console.Write("Digite o sexo (M/F): ");
    sexo[i] = char.Parse(Console.ReadLine().ToUpper());

    if (altura[i] > maior_altura)
    {
        maior_altura = altura[i];
    }
    if (altura[i] < menor_altura)
    {
        menor_altura = altura[i];
    }

    if (sexo[i] == 'F')
    {
        soma_f += altura[i];
        qtd_f++;
    }
    else if (sexo[i] == 'M')
    {
        qtd_m++;
    }
}

Console.WriteLine($"Maior altura: {maior_altura}");
Console.WriteLine($"Menor altura: {menor_altura}");
if (qtd_f > 0)
{
    double mediaAlturasMulheres = soma_f / qtd_f;
    Console.WriteLine($"Média de altura das mulheres: {mediaAlturasMulheres}");
}
else
{
    Console.WriteLine("Não há mulheres no grupo.");
}
Console.WriteLine($"Número de homens: {qtd_m}");