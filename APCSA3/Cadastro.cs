using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    class Cadastro: ICadastro
    {
        List<Doador> doadores = new List<Doador>();
        List<DoadorMensalista> mensalistas = new List<DoadorMensalista>();
        List<Beneficiario> beneficiarios = new List<Beneficiario>();
        List<Doacao> doacoes = new List<Doacao>();

        public void CadastrarDoador(Pessoa p)
        {
            Doador d = new Doador(p);
            doadores.Add(d);
        }

        public void CadastrarDoador(Doador d)
        {
            doadores.Add(d);
        }

        public void CadastrarDoadorMensalista(Pessoa p, float ValorContribuicaoMensal)
        {
            DoadorMensalista d = new DoadorMensalista(p, ValorContribuicaoMensal);
            mensalistas.Add(d);
        }

        public void CadastrarDoadorMensalista(DoadorMensalista d)
        {
            mensalistas.Add(d);
        }

        public void CadastrarBeneficiario(Pessoa p, string Endereco, float Renda, int QtdPessoasFamilia)
        {
            Beneficiario b = new Beneficiario(p, Endereco, Renda, QtdPessoasFamilia);
            beneficiarios.Add(b);
        }

        public void CadastrarBeneficiario(Beneficiario b)
        {
            beneficiarios.Add(b);
        }

        public void CadastrarDoacao(int Id, Doador x, Beneficiario b, ItemDoacao i, DateTime DataDoacao)
        {
            Doacao d = new Doacao(Id, x, b, i, DataDoacao);
            doacoes.Add(d);
        }

        public void MostrarDoadores()
        {
            Console.WriteLine("Doadores");
            Console.WriteLine("-----------------------------");
            foreach (Doador item in doadores)
            {
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - CPF: {item.Cpf}.");
            }
            Console.WriteLine("-----------------------------");
        }

        public void MostrarDoadoresMensalistas()
        {
            Console.WriteLine("Doadores Mensalistas");
            Console.WriteLine("-----------------------------");
            foreach (DoadorMensalista item in mensalistas)
            {
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - CPF: {item.Cpf} - Valor de Contribuição Mensal: {item.ValorContribuicaoMensal}.");
            }
            Console.WriteLine("-----------------------------");
        }

        public void MostrarReceptores()
        {
            Console.WriteLine("Beneficiários");
            Console.WriteLine("-----------------------------");
            foreach (Beneficiario item in beneficiarios)
            {
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - CPF: {item.Cpf} - Endereço: {item.Endereco} - Renda: {item.Renda} - Quantidade de pessoas na família: {item.QtdPessoasFamilia}.");
            }
            Console.WriteLine("-----------------------------");
        }

        public void MostrarDoacoesData(DateTime Data)
        {
            foreach(Doacao item in doacoes)
            {
                if(Data == item.DataDoacao)
                {
                    Console.WriteLine($"Doações feitas na data: {Data}");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine($"Doador: {item.Doador} - Beneficiário: {item.Beneficiario} - Item doado: {item.Item}.");
                    Console.WriteLine("-----------------------------");
                }
            }
        }

        public void MostrarDoacoesTotais()
        {
            Console.WriteLine("Doações");
            Console.WriteLine("-----------------------------");
            foreach (Doacao item in doacoes)
            {
                Console.WriteLine($"Doador: {item.Doador} - Beneficiário: {item.Beneficiario} - Item doado: {item.Item} - Data: {item.DataDoacao}");
            }
            Console.WriteLine("-----------------------------");
        }
    }
}