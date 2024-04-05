using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro:");

        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(EhPar(numero));
    }

 
    static bool EhPar(int num)
    {
        return num % 2 == 0;
    }
}
