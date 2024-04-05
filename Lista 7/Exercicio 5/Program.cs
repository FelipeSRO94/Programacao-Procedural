using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[4, 4];

        PreencherMatriz(matriz);

        if (VerificarBalista(matriz))
        {
            Console.WriteLine("Fique atento! existem balistas no tabuleiro");
        }
        else
        {
            Console.WriteLine("Não há balistas no tabuleiro");
        }
    }

    static void PreencherMatriz(int[,] matriz)
    {
        Console.WriteLine("Digite os elementos da matriz:");

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    static bool VerificarBalista(int[,] matriz)
    {
        foreach (int num in matriz)
        {
            if (num == 0)
            {
                return true;
            }
        }
        return false;
    }
}

