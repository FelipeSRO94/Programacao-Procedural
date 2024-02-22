using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main (string[] args)
    {

        Console.WriteLine("Digite a quantidade de centavos que deseja converter: ");
        int dinheiroTotal = int.Parse(Console.ReadLine());

        int reais = dinheiroTotal / 100;
        int centavos = dinheiroTotal % 100;

        Console.WriteLine("O total em dinheiro é: " + reais + " real(is) e " + centavos + " centavo(s)");
    }

}