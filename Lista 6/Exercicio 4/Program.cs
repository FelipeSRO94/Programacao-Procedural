using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[3, 3];

        Console.WriteLine("Digite 9 números inteiros:");

        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                int numero = int.Parse(Console.ReadLine());
                matriz[linha, coluna] = (linha + coluna == 2) ? numero * 2 : numero;
            }
        }

        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write(matriz[linha, coluna]);
                if (coluna < 2) Console.Write("|");
            }
            Console.WriteLine();
        }
    }
}
