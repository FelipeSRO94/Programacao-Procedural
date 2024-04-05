using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número inteiro:");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número inteiro:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número inteiro:");
        int numero3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("O maior número é: " + MaiorNumero(numero1, numero2, numero3));
    }

    static int MaiorNumero(int num1, int num2, int num3)
    {
        int maior = num1;

        if (num2 > maior)
        {
            maior = num2;
        }

        if (num3 > maior)
        {
            maior = num3;
        }

        return maior;
    }
}