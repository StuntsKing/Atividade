using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    interface ICadastro
    {
        void CadastrarDoador(Pessoa p);
        void CadastrarBeneficiario(Pessoa p, string Endereco, float Renda, int QtdPessoasFamilia);
        void CadastrarDoacao(int Id, Doador d, Beneficiario b, ItemDoacao i, DateTime DataDoacao);
        void MostrarDoadores();
        void MostrarReceptores();
        void MostrarDoacoesData(DateTime Data);
        void MostrarDoacoesTotais();
    }
}