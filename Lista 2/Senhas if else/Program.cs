using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o Nome de usuario: ");
        string nomeUsuario = Console.ReadLine();

        Console.WriteLine("Digite a senha: ");
        string senhaUsuario = Console.ReadLine();

        if (nomeUsuario == "admin" && senhaUsuario == "123senha")
        {
            Console.WriteLine("Login realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Credenciais invalidas!");
        }
    }
}