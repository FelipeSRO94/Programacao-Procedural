using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Contagem Crescente e Decrescente:");
        for (int cont = 0; cont <= 100; cont += 2)
        {
            Console.WriteLine($"{cont} - {200 - cont * 2}");
        }
    }
}