using System;

struct Pizza
{
    public int id;
    public string sabor;
    public double preco;
}

class Program
{
    static void Main(string[] args)
    {
        Pizza minhaPizza;

        Console.WriteLine("Insira o ID da pizza:");
        minhaPizza.id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira o sabor da pizza:");
        minhaPizza.sabor = Console.ReadLine();

        Console.WriteLine("Insira o preço da pizza:");
        minhaPizza.preco = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Dados da pizza:");
        Console.WriteLine("ID: " + minhaPizza.id);
        Console.WriteLine("Sabor: " + minhaPizza.sabor);
        Console.WriteLine("Preço: " + minhaPizza.preco.ToString("C"));
    }
}
