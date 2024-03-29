using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[10];

        
        Console.WriteLine("Digite 10 nomes:");

        for (int nome = 0; nome < 10; nome++)
        {
            Console.Write($"Nome {nome + 1}: ");
            nomes[nome] = Console.ReadLine();
        }

        
        Console.WriteLine("\nNomes nos índices pares, do último para o primeiro:");

        for (int nome = 9; nome >= 0; nome -= 2)
        {
            Console.WriteLine(nomes[nome]);
        }
    }
}
