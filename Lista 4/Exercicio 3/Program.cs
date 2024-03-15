using System;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro.InicializaTabuleiro();
        Tabuleiro.ImprimeTabuleiro();
    
        for (int linha = 0; linha < 8; linha++)
        {
            for (int coluna = 0; coluna < 8; coluna++)
            {
                if (linha == 0 || linha == 8 - 1 || coluna == 0 || coluna == 8 - 1)
                {
                    Tabuleiro.Adicionar(linha, coluna,"S");
                }
            }
        }
        Tabuleiro.ImprimeTabuleiro();
    }
}
