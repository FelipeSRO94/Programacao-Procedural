using System;

class Program
{
    static void Main(string[] args)
    {
        
        int[,] matriz = new int[3, 3];

        Console.WriteLine("Digite 9 números inteiros para preencher a matriz:");

        for (int numero = 0; numero < 3; numero++)
        {
            for (int numerico = 0; numerico < 3; numerico++)
            {
                Console.Write($"Número na posição [{numero},{numerico}]: ");
                matriz[numero, numerico] = int.Parse(Console.ReadLine());
            }
        }

        int somaDiagonal = 0;
        for (int numero = 0; numero < 3; numero++)
        {
            somaDiagonal += matriz[numero, numero];
        }

        Console.WriteLine($"\nA soma dos valores da diagonal principal é: {somaDiagonal}");
    }
}
