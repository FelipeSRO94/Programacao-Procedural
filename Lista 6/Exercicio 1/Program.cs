using System;

class Program
{
    static void Main(string[] args)
    {
        int NOMES = 10;

        string[] nome = new string[NOMES];

        for (int i = 0; i < NOMES; i++)
        {
            Console.Write($"Digite o nome {i + 1}: ");
            nome[i] = Console.ReadLine();
        }

        Console.Write("Digite o nome para busca: ");
        string nomeBusca = Console.ReadLine();

        bool achou = false;
        for (int contador = 0; contador < nomes.length; contador++)
        {
            if (nome[i] == nomeBusca)
            {
                nomeBusca = true;
            }

            if (nomeBusca)
            {
                System.Console.WriteLine("Achou!");
            }
            else
            {
                System.Console.WriteLine("Nome não encontrado");
            }
        }
    }
}
