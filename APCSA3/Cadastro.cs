using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    class Cadastro: ICadastro
    {
        List<Doador> doadores = new List<Doador>();
        List<Beneficiario> beneficiarios = new List<Beneficiario>();
        List<Doacao> doacoes = new List<Doacao>();

        public void CadastrarDoador(Pessoa p)
        {
            Doador d = new Doador(p);
            doadores.Add(d);
        }

        public void CadastrarBeneficiario(Pessoa p, string Endereco, float Renda, int QtdPessoasFamilia)
        {
            Beneficiario b = new Beneficiario(p, Endereco, Renda, QtdPessoasFamilia);
            beneficiarios.Add(b);
        }

        public void CadastrarDoacao(int Id, Doador x, Beneficiario b, ItemDoacao i, DateTime DataDoacao)
        {
            Doacao d = new Doacao(Id, x, b, i, DataDoacao);
            doacoes.Add(d);
            x.QtdDoacoesFeitas++;
            x.ValorDoado = x.ValorDoado + i.Valor;
            b.QtdDoacoesRecebidas++;
        }

        public void MostrarDoadores()
        {
            Console.WriteLine("Doadores");
            Console.WriteLine("-----------------------------");
            foreach (Doador item in doadores)
            {
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - CPF: {item.Cpf} - Valor doado: {item.ValorDoado} - Quantidade de doacões feitas: {item.QtdDoacoesFeitas}.");
            }
            Console.WriteLine("-----------------------------");
        }

        public void MostrarReceptores()
        {
            Console.WriteLine("Beneficiários");
            Console.WriteLine("-----------------------------");
            foreach (Beneficiario item in beneficiarios)
            {
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - CPF: {item.Cpf} - Endereço: {item.Endereco} - Renda: {item.Renda} - Quantidade de pessoas na família: {item.QtdPessoasFamilia} - Quantidade de doações recebidas: {item.QtdDoacoesRecebidas}.");
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