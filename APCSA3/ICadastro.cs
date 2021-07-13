using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    interface ICadastro
    {
        void CadastrarDoador(Pessoa p);
        void CadastrarDoador(Doador d);
        void CadastrarDoadorMensalista(Pessoa p, float ValorContribuicaoMensal);
        void CadastrarDoadorMensalista(DoadorMensalista d);
        void CadastrarBeneficiario(Pessoa p, string Endereco, float Renda, int QtdPessoasFamilia);
        void CadastrarBeneficiario(Beneficiario b);
        void CadastrarDoacao(int Id, Doador d, Beneficiario b, ItemDoacao i, DateTime DataDoacao);
        void MostrarDoadores();
        void MostrarDoadoresMensalistas();
        void MostrarReceptores();
        void MostrarDoacoesData(DateTime Data);
        void MostrarDoacoesTotais();
    }
}