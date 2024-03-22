using System;

class Program
{
    static void Main(string[] args)
    {
        for (int cont = 10; cont >= 1; cont--)
        {
            Console.WriteLine($"Tabuada do {cont}:\n");
            for (int num = 0; num <= 10; num++)
            {
                Console.WriteLine($"{cont} x {num} = {cont * num}");
            }
            Console.WriteLine();
        }
    }
}