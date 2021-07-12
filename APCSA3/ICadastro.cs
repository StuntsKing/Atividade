using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    interface ICadastro
    {
        void CadastrarDoador(Pessoa p);
        void CadastrarBeneficiario(Pessoa p, string Endereco, float Renda, int QtdPessoasFamilia, int QtdDoacoesRecebidas);
        void CadastrarDoacao();
        void MostrarDoadores();
        void MostrarReceptores();
        void MostrarDoacoesData();
        void MostrarDoacoesTotais();
    }
}