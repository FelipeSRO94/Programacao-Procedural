using System;

class Program
{
    static void Main(string[] args)
    {
        const string USUARIO_ESPERADO = "admin";
        const string SENHA_ESPERADA = "123admin";
        const int NUM_TENTATIVAS = 3;

        int tentativas = 0;
        string usuario, senha;

        do
        {
            Console.WriteLine("Digite seu nome de usuario: ");
            usuario = Console.ReadLine();

            Console.WriteLine("Digite sua senha: ");
            senha = Console.ReadLine();

            if (usuario == USUARIO_ESPERADO && senha == SENHA_ESPERADA)
            {
                System.Console.WriteLine("Login realizado com sucesso!");
                return;    
            }
            else
            {
                System.Console.WriteLine("Nome de usuario ou senha incorretos. \nTente novamente.");
                tentativas++;
            }
        } while (tentativas < NUM_TENTATIVAS);
        System.Console.WriteLine("Sua conta foi bloqueada! \nEntre em contato com nossa equipe.");
    }
}