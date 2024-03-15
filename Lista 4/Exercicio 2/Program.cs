using System;

class Program
{
    static void Main(string[] args)
    {
        int altura;

        while (true)
        {
            Console.WriteLine("Digite a altura do triângulo (entre 1 e 9):");
            if (int.TryParse(Console.ReadLine(), out altura) && altura >= 1 && altura <= 9)
            {
                break;
            }
            Console.WriteLine("Altura inválida, insira uma altura entre 1 e 9:");
        }

        for (int i = 1; i <= altura; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
