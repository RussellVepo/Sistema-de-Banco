using SistemadeBanco.Enumeradores;
using System;
using System.Globalization;

namespace SistemadeBanco
{
    class SistemaBanco
    {


        static void Main()
        {
            int funcao = 0;
            Console.WriteLine("Bem Vindo ao Banco Vepo, Escolhas as opções abaixo:");
            Console.WriteLine("[1] Cadastro | [2] Saldo | [3] Saque | [4] Deposito | [0] Sair");
            for (; ; )
            {
                string texto = (Console.ReadLine());

                if (!Int32.TryParse(texto, out funcao))
                    Console.WriteLine("favor escolha as opções");
                else
                    break;
            }


            switch ((EBancoFuncoes)funcao)
            {
                case EBancoFuncoes.Cadastro:
                    {
                        Console.WriteLine("Função escolhida Cadastro");break;
                    
                    }
                case EBancoFuncoes.Saldo:
                    {
                        Console.WriteLine("Função escolhida Saldo"); break;

                    }
                case EBancoFuncoes.Saque:
                    {
                        Console.WriteLine("Função escolhida Saque"); break;
                    }
                case EBancoFuncoes.Desposito:
                    {
                        Console.WriteLine("Função escolhida Depositos"); break;
                    }
                case EBancoFuncoes.Sair:
                    {
                        Console.WriteLine("Função escolhida Sair"); break;
                    }
                default: break;
            }
        }



        public class Cadastro
        {
            private int Id;
            private string Nome;
            private string Endereco;
            private string Telefone;
            private string Email;

            public Cadastro(int id, string nome, string endereco, string telefone, string email)
            {


                this.Id = id;
                this.Nome = nome;
                this.Telefone = telefone;
                this.Email = email;
            }
        }
    }
}