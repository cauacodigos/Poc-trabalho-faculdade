using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static conexaoBanco.acessoBanco acesso = new conexaoBanco.acessoBanco();

        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 para cadastrar funcionario e 2 para cadastro de fornecedor");
            string choice = Console.ReadLine();

            if (choice == "1")  {
                Funcionario();  
                Console.Write("Usuario cadastrado!");
            }

            if (choice == "2")
            {  
                Fornecedor();
                Console.Write("Fornecedor cadastrado!");

            }
        }

        public  static void Funcionario ()
        {
            Console.WriteLine("Digite seu email:");
            string email = Console.ReadLine();

            Console.WriteLine("Digite sua senha:");
            string senha = Console.ReadLine();

            Console.WriteLine("Digite seu cargo:");
            string cargo = Console.ReadLine();

            Console.WriteLine("Digite seu nome completo:");
            string nome = Console.ReadLine();

            acesso.CadastroFuncionario(nome, email, senha, cargo);

        }

        public static void Fornecedor ()
        {
            Console.WriteLine("Insira  o nome da empresa:");
            string nomeEmpresa = Console.ReadLine();

            Console.WriteLine("Insira o email da empresa");
            string emailEmpresa = Console.ReadLine();

            Console.WriteLine("Insira o telefone (sem ddd)");
            string telefone = Console.ReadLine();

            Console.WriteLine("Insira seu endereco");
            string endereco = Console.ReadLine();

            Console.WriteLine("Insira o tipo de produto vendido:");
            string tipoProduto = Console.ReadLine();

            acesso.CadastroFornecedor(nomeEmpresa, emailEmpresa, telefone, endereco, tipoProduto);
        }
    }
}
