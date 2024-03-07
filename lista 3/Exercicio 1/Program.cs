using System;

class Program
{
  static void Main(string[] args)
  {
    const int NUMERO_HAB = 3;
    double maiorSalario = 0;
    double somatoriaSalarial = 0;
    int somatoriaFilhos = 0;
    

    for (int i = 1; i <= NUMERO_HAB; i++)
    {
        System.Console.WriteLine("Digite o salario: ");
        double salario = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite o numero de filhos(as): ");
        int numeroFilhos = int.Parse(Console.ReadLine());
        
        somatoriaSalarial += salario;
        somatoriaFilhos += numeroFilhos;
        
        if (salario > maiorSalario)
        {
            maiorSalario = salario;
        }
    }

    double mediaSalarial = somatoriaSalarial / NUMERO_HAB;
    double mediaFilhos = somatoriaFilhos / NUMERO_HAB;

    System.Console.WriteLine("Média salarial = " + Math.Round(mediaSalarial, 2) + " R$." );
    System.Console.WriteLine("Media de núnemro de filhos = " + Math.Round(mediaFilhos, 2));
    System.Console.WriteLine("Maior salário = " + Math.Round(maiorSalario, 2));
  }   
}