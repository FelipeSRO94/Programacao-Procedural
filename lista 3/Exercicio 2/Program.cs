using System;

class Program
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Qantos itens você comprou ?");
        int itens = int.Parse(Console.ReadLine());

       
        const double VALOR_MINIMO = 150.00;
        double total = 0;
        int contador = 0;

        while (contador < itens)
        {
            System.Console.WriteLine("Digite o valor do item: ");
            double valorItem = double.Parse(Console.ReadLine());
            total += valorItem;
            contador++;
        }

        if (total >= VALOR_MINIMO)
        {
            System.Console.WriteLine("Parabéns !\nVocê ganhou frete gratis em sua compra de valor total: " + total);  
        }
        else
        {
            System.Console.WriteLine("Sua compra não possui frete gratis.");
        }

    }
}
