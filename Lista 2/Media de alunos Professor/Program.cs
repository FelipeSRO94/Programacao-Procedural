using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quarta nota: ");
        double nota4 = double.Parse(Console.ReadLine());

        double mediaFinal = (nota1 + nota2 + nota3 + nota4) / 4;

        Console.WriteLine("A média final do aluno é: " + mediaFinal);


        if (mediaFinal >= 5.0)
        {
            Console.WriteLine("Aluno aprovado");
        }
        else if (mediaFinal < 5.0 && mediaFinal >= 3.0)
        {
            Console.WriteLine("Aluno em recuperação");
        }
        else
        {
            Console.WriteLine("Aluno reprovado");
        }
    }
}
