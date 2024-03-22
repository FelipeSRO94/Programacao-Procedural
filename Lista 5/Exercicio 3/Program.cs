using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o tamanho da altura do retângulo:");
        int altura = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o tamanho da base do retângulo:");
        int baseRetangulo = int.Parse(Console.ReadLine());

        Console.WriteLine("Retângulo de asteriscos:");

        for (int al = 0; al < altura; al++)
        {
            for (int baseR = 0; baseR < baseRetangulo; baseR++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
