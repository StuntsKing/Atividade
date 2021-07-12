using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    class Cadastro: ICadastro
    {
        List<Doador> doadores = new List<Doador>();
        List<Beneficiario> beneficiarios = new List<Beneficiario>();

        public void CadastrarDoador(Pessoa p)
        {
            Doador d = new Doador(p);
            doadores.Add(d);
        }

        public void CadastrarBeneficiario(Pessoa p, string Endereco, float Renda, int QtdPessoasFamilia, int QtdDoacoesRecebidas)
        {
            Beneficiario b = new Beneficiario(p, Endereco, Renda, QtdPessoasFamilia, QtdDoacoesRecebidas);
            beneficiarios.Add(b);
        }

        public void CadastrarDoacao()
        {

        }

        public void MostrarDoadores()
        {
            foreach (Doador item in doadores)
            {
                Console.WriteLine("Doadores");
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"{item.Id}  {item.Nome}  {item.Cpf}  {item.ValorDoado}  {item.QtdDoacoesFeitas}");
                Console.WriteLine("-----------------------------");
            }
        }

        public void MostrarReceptores()
        {
            foreach (Beneficiario item in beneficiarios)
            {
                Console.WriteLine("Beneficiários");
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"{item.Id}  {item.Nome}  {item.Cpf}  {item.Endereco}  {item.Renda}  {item.QtdPessoasFamiia}  {item.QtdDoacoesRecebidas}");
                Console.WriteLine("-----------------------------");
            }
        }

        public void MostrarDoacoesData()
        {

        }

        public void MostrarDoacoesTotais()
        {

        }
    }
}