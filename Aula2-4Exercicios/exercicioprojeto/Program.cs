using System;

namespace exercicioprojeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string email;
            string senha;
            double cpf;
            string nomeCliente;
            string dataNascimento;
            double cep;
            string endereco;
            int numero;
            string bairro;
            string estado;
            string cidade;


            Console.WriteLine("Insira seu email");
            email = Console.ReadLine();

            Console.WriteLine("Insira sua senha");
            senha = Console.ReadLine();

            Console.WriteLine("Insira seu cpf/cpnj");
            cpf = double.Parse (Console.ReadLine());

            Console.WriteLine("Insira seu nome completo");
            nomeCliente  = Console.ReadLine();

            Console.WriteLine("Insira sua data de nascimento");
            dataNascimento = Console.ReadLine();

            Console.WriteLine("CEP");
            cep = double.Parse(Console.ReadLine() );

            Console.WriteLine("Endereço");
            endereco = Console.ReadLine();

            Console.WriteLine("Numero");
            numero = int.Parse (Console.ReadLine());

            Console.WriteLine("Bairro");
            bairro = Console.ReadLine();

            Console.WriteLine("Estado");
            estado = Console.ReadLine();

            Console.WriteLine("Cidade");
            cidade = Console.ReadLine();
        }
    }
}
