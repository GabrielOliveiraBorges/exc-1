Console.Write("Digite a quantidade de mercadorias: ");
int qtd = int.Parse(Console.ReadLine());

string[] nome = new string[qtd];
double[] preco_compra = new double[qtd];
double[] preco_venda = new double[qtd];
int lucro_menor = 0, lucro_medio = 0, lucro_maior = 0;
double total_compra = 0, total_venda = 0, lucro_total = 0;

for (int i = 0; i < qtd; i++)
{
    Console.Write($"Digite o nome da {i + 1}ª mercadoria: ");
    nome[i] = Console.ReadLine();

    Console.Write($"Digite o preço de compra de {nome[i]}: ");
    preco_compra[i] = double.Parse(Console.ReadLine());

    Console.Write($"Digite o preço de venda de {nome[i]}: ");
    preco_venda[i] = double.Parse(Console.ReadLine());

    double lucro = preco_venda[i] - preco_compra[i];
    double percentualLucro = (lucro / preco_compra[i]) * 100;

    if (percentualLucro < 10)
    {
        lucro_menor++;
    }
    else if (percentualLucro <= 20)
    {
        lucro_medio++;
    }
    else
    {
        lucro_maior++;
    }

    total_compra += preco_compra[i];
    total_venda += preco_venda[i];
    lucro_total += lucro;
}

Console.WriteLine($"Quantidade de mercadorias com lucro < 10%: {lucro_menor}");
Console.WriteLine($"Quantidade de mercadorias com lucro entre 10% e 20%: {lucro_medio}");
Console.WriteLine($"Quantidade de mercadorias com lucro > 20%: {lucro_maior}");
Console.WriteLine($"Valor total de compra: {total_compra}");
Console.WriteLine($"Valor total de venda: {total_venda}");
Console.WriteLine($"Lucro total: {lucro_total}");