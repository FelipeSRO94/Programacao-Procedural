using System;

class Program
{
    static void Main(string[] args)
    {
        int[] pesosVagoes = new int[12];

        PreencherVetor(pesosVagoes);

        VerificarPeso(pesosVagoes);
    }

    static void PreencherVetor(int[] vetor)
    {
        Console.WriteLine("Digite o peso de cada vagão:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Vagão {i + 1}: ");
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    static void VerificarPeso(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] > 50)
            {
                Console.WriteLine($"{i + 1}° vagao ultrapassou o limite de peso");
            }
        }
    }
}
