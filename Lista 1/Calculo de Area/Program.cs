using System;

class Program
{
    public static void Main (string[] args)
    {
        Console.WriteLine("Digite o numero da base do triangulo: ");
        double baseTriangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o numero da altura do triangulo: ");
        double alturaTriangulo = double.Parse(Console.ReadLine());

        double areaTriangulo = (baseTriangulo * alturaTriangulo)/ 2;

        bool areaMaiorQue20 = areaTriangulo > 20;

        Console.WriteLine("A área do triangulo é mior que 20 ? " + (areaMaiorQue20 ? "Verdadeiro" : "Falso"));

        
    }
}