using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class conexaoBanco
    {
    
        public  class acessoBanco
        {

            private SqlCommand qryexecute;
            private SqlConnection OpenConnection()
            {
                
                try
                {
                    string connectionString = @"Data Source=DESKTOP-1C31A26\SQLEXPRESS;Initial Catalog=pimFazenda;User ID=caua ;Password=12345";
                    SqlConnection conec = new SqlConnection(connectionString);
                    conec.Open(); 
                    return conec;
                    Console.WriteLine("Connection Open !");
                    
                }
                catch (Exception)
                {
                    throw;
                }

               
            }
            public void ClosedConneciton(SqlConnection conec)
            {
                conec.Close();  
            }


            public void CadastroFuncionario (string nome, string email, string senha, string cargo)
                {
                   SqlConnection conec = OpenConnection();

                string sequal = "INSERT INTO Funcionarios (emailFuncionario, senhaFuncionario, cargoFuncionario, nomeFuncionario) values";
                 sequal = sequal +  "('" + email + "','" + senha + "','" + cargo + "','" + nome + "')"; 

                qryexecute = new SqlCommand(sequal, conec);
                qryexecute.ExecuteNonQuery();
                ClosedConneciton (conec); 
            }

            public void CadastroFornecedor(string nomeEmpresa, string email, string telefone, string endereco, string tipoProduto)
            {
                SqlConnection conec = OpenConnection();

                
                Random random = new Random();
                string id = random.Next(100000, 999999).ToString();

                string sequal = "INSERT INTO Fornecedor (idFornecedor, nomeEmpresa, email, telefone, endereco, tipoProduto) VALUES ";
                sequal = sequal +  "('" + id + "','" + nomeEmpresa + "','" + email + "','" + telefone + "','" + endereco + "','" + tipoProduto + "')";

                qryexecute = new SqlCommand(sequal, conec);
                qryexecute.ExecuteNonQuery();
                ClosedConneciton(conec);
            }
        }
        }
    }


