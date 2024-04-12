using System;

struct Produto
{
    public int id;
    public string nome;
    public double preco;
    public bool disponivelEmEstoque;
}

class Program
{
    static void Main(string[] args)
    {
        Produto[] produtos = new Produto[4];

        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine("Insira o ID do produto:");
            produtos[i].id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o nome do produto:");
            produtos[i].nome = Console.ReadLine();

            Console.WriteLine("Insira o preço do produto:");
            produtos[i].preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O produto está disponível em estoque? (true/false):");
            produtos[i].disponivelEmEstoque = Convert.ToBoolean(Console.ReadLine());
        }

        Console.WriteLine("Produtos disponíveis na vitrine:");
        foreach (var produto in produtos)
        {
            if (produto.disponivelEmEstoque)
            {
                Console.WriteLine("Nome: " + produto.nome);
                Console.WriteLine("Preço: " + produto.preco.ToString("C"));
            }
        }
    }
}
